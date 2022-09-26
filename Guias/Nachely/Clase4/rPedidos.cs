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
    public partial class rPedidos : Form
    {
        private SqlConnection cnn;
        private SqlCommand insert;
        private string sCn;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public rPedidos()
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_Cliente FROM CLIENTES", cnn);
            da.Fill(ds, "CLIENTES");
            cbCliente.DataSource = ds.Tables[0].DefaultView;
            cbCliente.ValueMember = "id_Cliente";
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string insert = $"INSERT INTO PEDIDOS VALUES ({cbCliente.Text}, {nUDcant.Value}, '{dTime1.Text}')";
                SqlCommand insert1 = new SqlCommand(insert, cnn);
                insert1.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Guardado exitosamente");
                cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rPedidos_Load(object sender, EventArgs e)
        {
            llenar();
        }
        private void Limpiar()
        {
            cbCliente.Text = "";
            nUDcant.Value = 0;
            dTime1.Text = "";
            lbNombreC.Text = "";
        }
        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero;
            if (!Int32.TryParse(this.cbCliente.Text, out numero))
            {

            }
            else
            {
                try
                {
                    cnn.Open();
                    int num1 = int.Parse(cbCliente.Text);
                    string seleccion = "SELECT * FROM CLIENTES WHERE id_Cliente = " + num1;
                    da = new SqlDataAdapter(seleccion, cnn);
                    dr = da.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        lbNombreC.Visible = true;
                        lbNombreC.Text = dr["NombreCliente"].ToString().Trim();
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

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
