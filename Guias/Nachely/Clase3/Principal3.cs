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

namespace DealerSystempt2.Guias.Nachely.Clase3
{
    public partial class Principal3 : Form
    {
        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        public Principal3()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = DESKTOP-K8OJCDL\SQLEXPRESS; Initial Catalog = DB_Sucarnet; Integrated Security=SSPI;";

            modificar1.Visible = false;

            Conexion con1 = new Conexion();

            con1.conectar();

            sCn1 = con1.cadena;

            conn1 = new SqlConnection(sCn1);
            conn1.Open();
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            textedad1.Visible = true;
            textnom1.Visible = true;
            textape1.Visible = true;
            modificar1.Visible = true;
            eliminar1.Visible = true;

            string seleccion;

            seleccion = "SELECT * FROM Participantes WHERE Codigo = '" + textcod1.Text + "'";

            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("Codigo", SqlDbType.VarChar);
            prm.Value = textcod1.Text;

            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                textnom1.Text = dr1["Nombres"].ToString().Trim();
                textape1.Text = dr1["Apellidos"].ToString().Trim();
                textedad1.Text = dr1["Edad"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
            }
        }

        private void modificar1_Click(object sender, EventArgs e)
        {
            string actualizar;

            actualizar = "UPDATE Participantes SET " +
                "Nombres = '" + textnom1.Text + "', Apellidos = '" + textape1.Text + "'" +
                ", Edad = " + textedad1.Text + " WHERE Codigo = '" + textcod1.Text + "'";

            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            cnn.Open();

            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Registrado");
            Reset();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            string actualizar;
            actualizar = "DELETE FROM Participantes WHERE Codigo = " + textcod1.Text + "";
            cnn.Open();
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);

            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("ELIMINADO");
            Reset();
        }
        private void Reset()
        {
            textedad1.Visible = false;
            textnom1.Visible = false;
            textape1.Visible = false;
            modificar1.Visible = false;

            textape1.Text = "";
            textcod1.Text = "";
            textnom1.Text = "";
            textedad1.Text = "";

            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }
    }
}
