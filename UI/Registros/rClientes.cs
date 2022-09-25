using DealerSystempt2.Conexion;
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

namespace DealerSystempt2.UI.Registros
{
    public partial class rClientes : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        //NACH
        public static string svname = @"LAPTOP-TN73JHLV\SQLEXPRESS";
        //BRIAN
        //public string svname = @"BRIAN-PC\BRIANSQLEXPRESS";
        public rClientes()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = $@"PROVIDER = SQLOLEDB; Data Source = {svname}; Initial Catalog = DealerSystem; Integrated Security=SSPI;";
            Cancelar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string query = $"EXEC sp_BuscarCliente {ClienteIdTextBox.Text}";

            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());
            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                ClienteIdTextBox.Text = dr1["ClienteId"].ToString();
                NombresTextBox.Text = dr1["Nombres"].ToString();
                ApellidosTextBox.Text = dr1["Apellidos"].ToString();
                TelefonoTextBox.Text = dr1["Telefono"].ToString();
                CedulaTextBox.Text = dr1["Cedula"].ToString();
                CelularTextBox.Text = dr1["Celular"].ToString();
                OcupacionTextBox.Text = dr1["Ocupacion"].ToString();
            }

            if (dr1 != null)
            {
                dr1.Close();
                HabilitarModificar();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;
                actualizar = "EXEC sp_EliminarCliente " + ClienteIdTextBox.Text;
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Cliente eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nuevo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comuniquese con los desarrolladores " + ex.Message, "Error");
                throw;
            }
        }
        

        private void InsertarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertarCliente {ClienteIdTextBox.Text}, '{NombresTextBox.Text}', '{ApellidosTextBox.Text}', '{CedulaTextBox.Text}', '{TelefonoTextBox.Text}', '{CelularTextBox.Text}', '{OcupacionTextBox.Text}'";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Cliente guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;

                actualizar = $"EXEC sp_ModificarCliente {ClienteIdTextBox.Text}, '{NombresTextBox.Text}', '{ApellidosTextBox.Text}', '{CedulaTextBox.Text}', '{TelefonoTextBox.Text}', '{CelularTextBox.Text}', '{OcupacionTextBox.Text}'";


                OleDbCommand datos = new OleDbCommand(actualizar, cnn);
                cnn.Open();

                datos.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Cliente modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comuniquese con los desarrolladores " + ex.Message, "Error");
                throw;
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            ClienteIdTextBox.Enabled = true;
            ClienteIdTextBox.ReadOnly = false;
            NombresTextBox.Enabled = false;
            ApellidosTextBox.Enabled = false;
            CedulaTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            CelularTextBox.Enabled = false;
            OcupacionTextBox.Enabled = false;
            EliminarButton.Enabled = false;
            InsertarButton.Enabled = false;
            ModificarButton.Enabled = false;
        }

        private void Nuevo()
        {
            ClienteIdTextBox.Clear();
            getUltimoCliente();
            NombresTextBox.Clear();
            ApellidosTextBox.Clear();
            CedulaTextBox.Clear();
            TelefonoTextBox.Clear();
            CelularTextBox.Clear();
            OcupacionTextBox.Clear();

            ClienteIdTextBox.Enabled = false;
            NombresTextBox.Enabled = true;
            ApellidosTextBox.Enabled = true;
            CedulaTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            CelularTextBox.Enabled = true;
            OcupacionTextBox.Enabled = true;


            ModificarButton.Enabled = false;
            InsertarButton.Enabled = true;
        }

        private void HabilitarModificar()
        {
            ClienteIdTextBox.Enabled = false;
            NombresTextBox.Enabled = true;
            ApellidosTextBox.Enabled = true;
            CedulaTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            CelularTextBox.Enabled = true;
            OcupacionTextBox.Enabled = true;
            ModificarButton.Enabled = true;
            InsertarButton.Enabled = false;
            EliminarButton.Enabled = true;
        }

        private bool Validar()
        {
            if(string.IsNullOrEmpty(NombresTextBox.Text))
            {
                MessageBox.Show("Completar el campo Nombres", "Validación", MessageBoxButtons.OKCancel);
                NombresTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(ApellidosTextBox.Text))
            {
                MessageBox.Show("Completar el campo Apellidos", "Validación", MessageBoxButtons.OKCancel);
                ApellidosTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                MessageBox.Show("Completar el campo Teléfono", "Validación", MessageBoxButtons.OKCancel);
                TelefonoTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(CedulaTextBox.Text))
            {
                MessageBox.Show("Completar el campo Cédula", "Validación", MessageBoxButtons.OKCancel);
                CedulaTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(CelularTextBox.Text))
            {
                MessageBox.Show("Completar el campo Celular", "Validación", MessageBoxButtons.OKCancel);
                CelularTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(OcupacionTextBox.Text))
            {
                MessageBox.Show("Completar el campo Ocupación", "Validación", MessageBoxButtons.OKCancel);
                OcupacionTextBox.Focus();
                return false;
            }
            return true;
        }

        private void getUltimoCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT top(1) ClienteId FROM Clientes ORDER BY ClienteId desc";

                SqlCommand command = new SqlCommand(query, conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    ClienteIdTextBox.Text = "1";
                }
                else
                {
                    int id = int.Parse(dt.Rows[0]["ClienteId"].ToString());
                    id++;
                    ClienteIdTextBox.Text = (id).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción");
            }


        }
    }
}
