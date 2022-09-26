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

namespace DealerSystempt2.Guias.Nachely.Clase4
{
    public partial class rUsuarios : Form
    {
        private SqlConnection cnn;
        private SqlCommand insert;
        private string sCn;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public rUsuarios()
        {
            InitializeComponent();
            Conexion con = new Conexion();
            con.conec();
            sCn = con.cadena;
            cnn = new SqlConnection(sCn);
        }
        public void llenar()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_Ciudad FROM CIUDADES", cnn);
            da.Fill(ds, "CIUDADES");
            Ciudadcombo.DataSource = ds.Tables[0].DefaultView;
            Ciudadcombo.ValueMember = "id_Ciudad";
        }
        private void Limpiar()
        {
            Nombrestxt.Text = "";
            usertxt.Text = "";
            passwordtxt.Text = "";
            EstadoRadio.Checked = false;
            Ciudadcombo.SelectedIndex = 0;
            lbNombreC.Text = "";
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = 0;
                if (EstadoRadio.Checked == true)
                {
                    valor = 1;
                }
                cnn.Open();
                string insert = $"INSERT INTO USUARIOS VALUES ('{Nombrestxt.Text}', '{usertxt.Text}', '{passwordtxt.Text}', {valor}, {Ciudadcombo.Text})";
                SqlCommand insert1 = new SqlCommand(insert, cnn);
                insert1.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Guardado exitosamente",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {
            llenar();
            if (Ciudadcombo.Items.Count < 0)
            {
                MessageBox.Show("No hay ciudades registradas, favor registre una.", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
                return;
            }
        }

        private void Ciudadcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero;
            if (!Int32.TryParse(this.Ciudadcombo.Text, out numero))
            {

            }
            else
            {
                try
                {
                    cnn.Open();
                    int num1 = int.Parse(Ciudadcombo.Text);
                    string seleccion = "SELECT * FROM CIUDADES WHERE id_Ciudad = " + num1;
                    da = new SqlDataAdapter(seleccion, cnn);
                    dr = da.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        lbNombreC.Visible = true;
                        lbNombreC.Text = dr["NombreCiudad"].ToString().Trim();
                    }
                    cnn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                if (dr != null)
                {
                    dr.Close();
                }
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
