using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Guias.Nachely.Clase3
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        public Form2()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.conectar();

            sCn = conexion.cadena;

            conn = new SqlConnection(sCn);

            conn.Open();
        }

        private void insertar2_Click(object sender, EventArgs e)
        {
            try
            {
                string inserpart;

                inserpart = "INSERT INTO Participantes (Codigo, Nombres, Apellidos, Edad)" +
                    "VALUES(@carnet, @nombre, @apellido, @edad)";

                insert1 = new SqlCommand(inserpart, conn);

                insert1.Parameters.Add(new SqlParameter("@carnet", SqlDbType.VarChar));
                insert1.Parameters["@carnet"].Value = textcod2.Text;

                insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                insert1.Parameters["@nombre"].Value = textnom2.Text;

                insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                insert1.Parameters["@apellido"].Value = textape2.Text;

                insert1.Parameters.Add(new SqlParameter("@edad", SqlDbType.VarChar));
                insert1.Parameters["@edad"].Value = textedad2.Text;

                insert1.ExecuteNonQuery();

                textedad2.Clear();
                textnom2.Clear();
                textcod2.Clear();
                textape2.Clear();
                MessageBox.Show("Participante guardado", "Exito");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                //throw;
            }
        }

        private void buscar2_Click(object sender, EventArgs e)
        {
            Principal3 form1 = new Principal3();
            form1.Show();
            this.Hide();
        }
    }
}
