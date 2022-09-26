using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Tareas.Nachely.Tarea3
{
    public partial class rEstudiantes : Form
    {
        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private SqlCommand insert1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        public rEstudiantes()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = DESKTOP-K8OJCDL\SQLEXPRESS; Initial Catalog = DB_Sucarnet; Integrated Security=SSPI;";

            Conexion con1 = new Conexion();

            con1.Conectar();

            sCn1 = con1.cadena;

            conn1 = new SqlConnection(sCn1);
            conn1.Open();

            PrimerNombretxt.Enabled = false;
            SegundoNombretxt.Enabled = false;
            PrimerApellidotxt.Enabled = false;
            SegundoApellidotxt.Enabled = false;
            EdadTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            EliminarButtom.Enabled = false;
            InsertarButton.Enabled = false;
            ModificarButton.Enabled = false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Alumno WHERE CodigoAlumno = '" + CodigotextBox.Text + "'";
            da1 = new SqlDataAdapter(query, conn1);
            SqlParameter prm = new SqlParameter("CodigoAlumno", SqlDbType.VarChar);
            prm.Value = CodigotextBox.Text;

            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                PrimerNombretxt.Text = dr1["PrimerNombre"].ToString().Trim();
                SegundoNombretxt.Text = dr1["SegundoNombre"].ToString().Trim();
                PrimerApellidotxt.Text = dr1["PrimerApellido"].ToString().Trim();
                SegundoApellidotxt.Text = dr1["SegundoApellido"].ToString().Trim();
                EdadTextBox.Text = dr1["Edad"].ToString().Trim();
                direccionTextBox.Text = dr1["Direccion"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
                HabilitarModificar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void Nuevo()
        {
            CodigotextBox.Clear();
            PrimerNombretxt.Clear();
            SegundoNombretxt.Clear();
            PrimerApellidotxt.Clear();
            SegundoApellidotxt.Clear();
            EdadTextBox.Clear();
            direccionTextBox.Clear();
            CodigotextBox.Enabled = true;
            PrimerNombretxt.Enabled = true;
            SegundoNombretxt.Enabled = true;
            PrimerApellidotxt.Enabled = true;
            SegundoApellidotxt.Enabled = true;
            EdadTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            ModificarButton.Enabled = false;
            InsertarButton.Enabled = true;
            CodigotextBox.Enabled = true;
        }

        private void HabilitarModificar()
        {
            CodigotextBox.Enabled = false;
            PrimerNombretxt.Enabled = true;
            SegundoNombretxt.Enabled = true;
            PrimerApellidotxt.Enabled = true;
            SegundoApellidotxt.Enabled = true;
            EdadTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            ModificarButton.Enabled = true;
            InsertarButton.Enabled = false;
            EliminarButtom.Enabled = true;
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string actualizar;

            actualizar = "UPDATE dbo.Alumno SET " +
                "PrimerNombre = '" + PrimerNombretxt.Text + "', SegundoNombre = '" + SegundoNombretxt.Text + "'" +
                ", PrimerApellido = '" + PrimerApellidotxt.Text + "', SegundoApellido = '" + SegundoApellidotxt.Text
                + "', Edad = " + EdadTextBox.Text + ", Direccion = '" + direccionTextBox.Text + "'";

            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            cnn.Open();

            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Registrado");
        }

        private void InsertarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inserpart;

                inserpart = "INSERT INTO dbo.Alumno (CodigoAlumno, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Edad, Direccion)" +
                    $"VALUES ('{CodigotextBox.Text}', '{PrimerNombretxt.Text}', '{SegundoNombretxt.Text}', '{PrimerApellidotxt.Text}', '{SegundoApellidotxt.Text}', {EdadTextBox.Text}, '{direccionTextBox.Text}')";
                insert1 = new SqlCommand(inserpart, conn1);


                insert1.ExecuteNonQuery();

                MessageBox.Show("Alumno guardado", "Exito");
                //conn1.Close();
                Nuevo();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }

        private void EliminarButtom_Click(object sender, EventArgs e)
        {
            string actualizar;
            actualizar = "DELETE FROM dbo.Alumno WHERE CodigoAlumno= '" + CodigotextBox.Text + "'";
            cnn.Open();
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);

            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("ELIMINADO");
            Nuevo();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            PrimerNombretxt.Enabled = false;
            SegundoNombretxt.Enabled = false;
            PrimerApellidotxt.Enabled = false;
            SegundoApellidotxt.Enabled = false;
            EdadTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            EliminarButtom.Enabled = false;
            InsertarButton.Enabled = false;
            ModificarButton.Enabled = false;
        }
    }
}
