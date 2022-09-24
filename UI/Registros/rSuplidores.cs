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
    public partial class rSuplidores : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        //NACH
        public static string svname = @"LAPTOP-TN73JHLV\SQLEXPRESS";
        //BRIAN
        //public string svname = @"BRIAN-PC\BRIANSQLEXPRESS";
        public rSuplidores()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = $@"PROVIDER = SQLOLEDB; Data Source = {svname}; Initial Catalog = DealerSystem; Integrated Security=SSPI;";

            Cancelar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void Nuevo()
        {
            Idtxt.ReadOnly = true;
            Nombretxt.Clear();
            Empresatxt.Clear();
            Correotxt.Clear();
            Telefonotxt.Clear();
            Observaciontxt.Clear();
            //tipoCmb.SelectedIndex = 0;
            Idtxt.Enabled = true;
            Nombretxt.Enabled = true;
            Empresatxt.Enabled = true;
            Correotxt.Enabled = true;
            Telefonotxt.Enabled = true;
            Observaciontxt.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnInsertar.Enabled = true;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertarSuplidor '{Nombretxt.Text}', '{Empresatxt.Text}', '{Telefonotxt.Text}', '{Correotxt.Text}', '{Observaciontxt.Text}'";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Suplidor guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //conn1.Close();
                Nuevo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(Nombretxt.Text))
            {
                MessageBox.Show("Completar el campo Nombre", "Validación", MessageBoxButtons.OKCancel);
                Nombretxt.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Empresatxt.Text))
            {
                MessageBox.Show("Completar el campo Empresa", "Validación", MessageBoxButtons.OKCancel);
                Empresatxt.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Telefonotxt.Text))
            {
                MessageBox.Show("Complete el Telefono", "Validación", MessageBoxButtons.OKCancel);
                Telefonotxt.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Correotxt.Text))
            {
                MessageBox.Show("Complete el Correo", "Validación", MessageBoxButtons.OKCancel);
                Correotxt.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Observaciontxt.Text))
            {
                MessageBox.Show("Complete el Observacion", "Validación", MessageBoxButtons.OKCancel);
                Observaciontxt.Focus();
                paso = false;
            }
            return paso;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;

                actualizar = $"EXEC sp_ModificarSuplidor {Idtxt.Text}, '{Nombretxt.Text}', '{Empresatxt.Text}', '{Telefonotxt.Text}', '{Correotxt.Text}', '{Observaciontxt.Text}'";


                OleDbCommand datos = new OleDbCommand(actualizar, cnn);
                cnn.Open();

                datos.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Suplidor modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comuniquese con los desarrolladores " + ex.Message, "Error");
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;
                actualizar = "EXEC sp_EliminarSuplidor " + Idtxt.Text;
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Suplidor eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nuevo();
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
            Idtxt.Enabled = true;
            Idtxt.ReadOnly = false;
            Nombretxt.Enabled = false;
            Empresatxt.Enabled = false;
            Correotxt.Enabled = false;
            Telefonotxt.Enabled = false;
            Observaciontxt.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_BuscarSuplidor " + Idtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                Empresatxt.Text = dr1["Empresa"].ToString().Trim();
                Nombretxt.Text = dr1["Nombre"].ToString().Trim();
                Telefonotxt.Text = dr1["Telefono"].ToString();
                Correotxt.Text = dr1["Correo"].ToString();
                Observaciontxt.Text = dr1["Observaciones"].ToString();
                
            }
            if (dr1 != null)
            {
                dr1.Close();
                HabilitarModificar();
            }
        }

        private void HabilitarModificar()
        {
            Idtxt.Enabled = false;
            Nombretxt.Enabled = true;
            Empresatxt.Enabled = true;
            Telefonotxt.Enabled = true;
            Correotxt.Enabled = true;
            Observaciontxt.Enabled = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnInsertar.Enabled = false;
        }
    }
}
