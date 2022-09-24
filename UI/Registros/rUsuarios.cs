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
    public partial class rUsuarios : Form
    {

        Connection conexion;
        OleDbConnection cnn;
        public rUsuarios()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = LAPTOP-TN73JHLV\SQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";
            Cancelar();
        }

        private void Nuevo()
        {
            getUltimaUsuario();
            Idtxt.ReadOnly = true;
            Nombretxt.Clear();
            Usertxt.Clear();
            Passtxt.Clear();
            tipoCmb.Text = "Seleccionar";
            Idtxt.Enabled = true;
            Nombretxt.Enabled = true;
            Usertxt.Enabled = true;
            Passtxt.Enabled = true;
            tipoCmb.Enabled = true;
            ActivoRadio.Enabled = true;
            ActivoRadio.Checked = true;
            btnInsertar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            Passtxt.Enabled = true;
        }

        private void getUltimaUsuario()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT top(1) ID FROM Usuarios ORDER BY ID desc";

                SqlCommand command = new SqlCommand(query, conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Idtxt.Text = "1";
                }
                else
                {
                    int id = int.Parse(dt.Rows[0]["Id"].ToString());
                    id++;
                    Idtxt.Text = (id).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción");
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertarUsuarios {Idtxt.Text}, '{Nombretxt.Text}', '{Usertxt.Text}', '{Passtxt.Text}', {tipoCmb.SelectedIndex+1}, {ActivoRadio.Checked}";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Usuario guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (string.IsNullOrEmpty(Usertxt.Text))
            {
                MessageBox.Show("Completar el campo Usuario", "Validación", MessageBoxButtons.OKCancel);
                Usertxt.Focus();
                paso = false;
            }
            else if (tipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un tipo de usuario", "Validación", MessageBoxButtons.OKCancel);
                tipoCmb.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Passtxt.Text))
            {
                MessageBox.Show("Complete la contraseña", "Validación", MessageBoxButtons.OKCancel);
                Passtxt.Focus();
                paso = false;
            }
            return paso;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;

                actualizar = $"EXEC sp_ModificarUsuarios {Idtxt.Text}, '{Nombretxt.Text}', '{Usertxt.Text}', '{Passtxt.Text}', {tipoCmb.SelectedIndex + 1}, {ActivoRadio.Checked}";


                OleDbCommand datos = new OleDbCommand(actualizar, cnn);
                cnn.Open();

                datos.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Usuario modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                actualizar = "EXEC sp_EliminarUsuarios " + Idtxt.Text;
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Usuario eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nuevo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comuniquese con los desarrolladores " + ex.Message, "Error");
                throw;
            }
        }

        private void Cancelar()
        {
            Idtxt.Enabled = true;
            Idtxt.ReadOnly = false;
            Nombretxt.Enabled = false;
            Usertxt.Enabled = false;
            Passtxt.Enabled = false;
            tipoCmb.Enabled = false;
            ActivoRadio.Enabled = false;
        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_BuscarUsuarios " + Idtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                Nombretxt.Text = dr1["Nombre"].ToString().Trim();
                Usertxt.Text = dr1["Usuario"].ToString().Trim();
                tipoCmb.SelectedIndex = int.Parse(dr1["Tipo"].ToString()) - 1;
                ActivoRadio.Checked = (bool)dr1["Estado"];
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
            Usertxt.Enabled = true;
            tipoCmb.Enabled = true;
            Passtxt.Enabled = true;
            ActivoRadio.Enabled = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnInsertar.Enabled = false;
        }
    }
}
