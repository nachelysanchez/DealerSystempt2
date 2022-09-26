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

namespace DealerSystempt2.Tareas.Nachely.Tarea4
{
    public partial class rCiudades : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        public rCiudades()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.conec();
            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);
        }

        private void btnIngresarC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string insert;
                insert = "INSERT INTO CIUDADES VALUES ('" + textBox1.Text + "')";
                insert1 = new SqlCommand(insert, conn);

                insert1.ExecuteNonQuery();
                textBox1.Clear();
                MessageBox.Show("Agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
