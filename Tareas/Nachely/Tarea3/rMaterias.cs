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
    public partial class rMaterias : Form
    {
        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private SqlCommand insert1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        public rMaterias()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = LAPTOP - TN73JHLV\SQLEXPRESS; Initial Catalog = DB_Sucarnet; Integrated Security=SSPI;";

            Conexion con1 = new Conexion();

            con1.Conectar();

            sCn1 = con1.cadena;

            conn1 = new SqlConnection(sCn1);
            conn1.Open();

            NombreTextBox.Enabled = false;
            UVTextBox.Enabled = false;
            prerequisitoTextBox.Enabled = false;
            EliminarButtom.Enabled = false;
            InsertarButton.Enabled = false;
            ModificarButton.Enabled = false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //conn1.Open();
            string query = "SELECT * FROM dbo.Materia WHERE CodigoMateria = '" + CodigotextBox.Text + "'";
            da1 = new SqlDataAdapter(query, conn1);
            SqlParameter prm = new SqlParameter("CodigoMateria", SqlDbType.VarChar);
            prm.Value = CodigotextBox.Text;

            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                NombreTextBox.Text = dr1["NombreMateria"].ToString().Trim();
                UVTextBox.Text = dr1["UV"].ToString().Trim();
                prerequisitoTextBox.Text = dr1["Prerequisitos"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            CodigotextBox.Clear();
            NombreTextBox.Clear();
            UVTextBox.Clear();
            prerequisitoTextBox.Clear();
            NombreTextBox.Enabled = true;
            UVTextBox.Enabled = true;
            prerequisitoTextBox.Enabled = true;
            ModificarButton.Enabled = false;
            InsertarButton.Enabled = true;
            CodigotextBox.Enabled = true;
        }

        private void HabilitarModificar()
        {
            CodigotextBox.Enabled = false;
            NombreTextBox.Enabled = true;
            UVTextBox.Enabled = true;
            prerequisitoTextBox.Enabled = true;
            ModificarButton.Enabled = true;
            InsertarButton.Enabled = false;
            EliminarButtom.Enabled = true;
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string actualizar;

            actualizar = "UPDATE dbo.Materia SET " +
                "NombreMateria = '" + NombreTextBox.Text + "', UV = " + UVTextBox.Text + "" +
                ", Prerequisitos = '" + prerequisitoTextBox.Text + "'";

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

                inserpart = "INSERT INTO dbo.Materia (CodigoMateria, NombreMateria, UV, Prerequisitos)" +
                    $"VALUES ('{CodigotextBox.Text}', '{NombreTextBox.Text}', {UVTextBox.Text}, '{prerequisitoTextBox.Text}')";
                insert1 = new SqlCommand(inserpart, conn1);

                //insert1.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Char));
                //insert1.Parameters["@codigo"].Value = CodigotextBox.Text;

                //insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                //insert1.Parameters["@nombre"].Value = NombreTextBox.Text;

                //insert1.Parameters.Add(new SqlParameter("@uv", SqlDbType.Int));
                //insert1.Parameters["@uv"].Value = UVTextBox.Text;

                //insert1.Parameters.Add(new SqlParameter("@prer", SqlDbType.VarChar));
                //insert1.Parameters["@prer"].Value = prerequisitoTextBox.Text;

                insert1.ExecuteNonQuery();

                //CodigotextBox.Clear();
                //NombreTextBox.Clear();
                //UVTextBox.Clear();
                //prerequisitoTextBox.Clear();
                MessageBox.Show("Materia guardada", "Exito");
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
            actualizar = "DELETE FROM dbo.Materia WHERE CodigoMateria = '" + CodigotextBox.Text + "'";
            cnn.Open();
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);

            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("ELIMINADO");
            Nuevo();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Enabled = false;
            UVTextBox.Enabled = false;
            prerequisitoTextBox.Enabled = false;
            EliminarButtom.Enabled = false;
            InsertarButton.Enabled = false;
            ModificarButton.Enabled = false;
        }
    }
}
