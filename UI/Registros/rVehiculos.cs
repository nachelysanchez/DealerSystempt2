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
    public partial class rVehiculos : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        public rVehiculos()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = LAPTOP-TN73JHLV\SQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";

            Modelotxt.Enabled = false;
            Preciotxt.Enabled = false;
            tipoCmb.Enabled = false;
            marcaCbm.Enabled = false;
            combustiblecmb.Enabled = false;
            colorcmb.Enabled = false;
            cantidadnumeric.Enabled = false;
            aniotxt.Enabled = false;
        }

        private void CargarComboBoxTipos()
        {
            string tipov = "SELECT * FROM TiposVehiculos";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(tipov, conexion.Conectar());
            da.Fill(ds, "dbo.TiposVehiculos");
            tipoCmb.DataSource = ds.Tables[0].DefaultView;
            tipoCmb.ValueMember = "TipoId";
            tipoCmb.DisplayMember = "Nombre";

        }

        private void HabilitarModificar()
        {
            Idtxt.Enabled = false;
            Modelotxt.Enabled = true;
            Preciotxt.Enabled = true;
            tipoCmb.Enabled = true;
            marcaCbm.Enabled = true;
            combustiblecmb.Enabled = true;
            colorcmb.Enabled = true;
            cantidadnumeric.Enabled = true;
            aniotxt.Enabled = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnInsertar.Enabled = false;
        }

        private void CargarComboBoxMarcas()
        {
            string marca = "SELECT * FROM Marcas";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter(marca, conexion.Conectar());


            da1.Fill(ds1, "dbo.Marcas");
            marcaCbm.DataSource = ds1.Tables[0].DefaultView;
            marcaCbm.ValueMember = "MarcaId";
            marcaCbm.DisplayMember = "Nombre";
        }

        private void CargarComboBoxColores()
        {
            string colores = "SELECT * FROM Colores";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(colores, conexion.Conectar());
            da2.Fill(ds2, "dbo.Colores");
            colorcmb.DataSource = ds2.Tables[0].DefaultView;
            colorcmb.ValueMember = "ColorId";
            colorcmb.DisplayMember = "Nombre";
        }

        private void CargarComboBoxCombustibles()
        {
            string marca = "SELECT * FROM Combustibles";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter(marca, conexion.Conectar());
            da1.Fill(ds1, "dbo.Combustibles");
            combustiblecmb.DataSource = ds1.Tables[0].DefaultView;
            combustiblecmb.ValueMember = "CombustibleId";
            combustiblecmb.DisplayMember = "Nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_BuscarVehiculos " + Idtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                Modelotxt.Text = dr1["Modelo"].ToString().Trim();
                Preciotxt.Text = dr1["Precio"].ToString().Trim();
                marcaCbm.SelectedIndex = int.Parse(dr1["MarcaId"].ToString()) - 1;
                tipoCmb.SelectedIndex = int.Parse(dr1["TipoId"].ToString()) - 1;
                cantidadnumeric.Value = int.Parse(dr1["CantidadDisponible"].ToString());
                colorcmb.SelectedIndex = int.Parse(dr1["ColorId"].ToString()) - 1;
                aniotxt.Text = dr1["Anio"].ToString();
                combustiblecmb.SelectedIndex = int.Parse(dr1["CombustibleId"].ToString()) - 1;
            }
            if (dr1 != null)
            {
                dr1.Close();
                HabilitarModificar();
            }
        }

        private void rVehiculos_Load(object sender, EventArgs e)
        {
            tipoCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            marcaCbm.DropDownStyle = ComboBoxStyle.DropDownList;
            combustiblecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            colorcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarComboBoxTipos();
            CargarComboBoxMarcas();
            CargarComboBoxColores();
            CargarComboBoxCombustibles();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void Nuevo()
        {
            getUltimoVehiculo();
            Idtxt.ReadOnly = true;
            Modelotxt.Clear();
            Preciotxt.Clear();
            //tipoCmb.SelectedIndex = 0;
            Idtxt.Enabled = true;
            Modelotxt.Enabled = true;
            Preciotxt.Enabled = true;
            tipoCmb.Enabled = true;
            marcaCbm.Enabled = true;
            combustiblecmb.Enabled = true;
            colorcmb.Enabled = true;
            cantidadnumeric.Enabled = true;
            aniotxt.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnInsertar.Enabled = true;
        }
        private void getUltimoVehiculo()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT top(1) VehiculoId FROM Vehiculos Order by VehiculoId desc";

                SqlCommand command = new SqlCommand(query, conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Idtxt.Text = "1";
                }
                else
                {
                    int id = int.Parse(dt.Rows[0]["VehiculoId"].ToString());
                    id++;
                    Idtxt.Text = (id).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción");
            }


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertarVehiculos {Idtxt.Text}, '{Modelotxt.Text}', {marcaCbm.SelectedIndex + 1}, {combustiblecmb.SelectedIndex + 1}, {Preciotxt.Text}, {(int)cantidadnumeric.Value}, {colorcmb.SelectedIndex + 1}, {aniotxt.Text}, {tipoCmb.SelectedIndex + 1}";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Vehículo guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(Modelotxt.Text))
            {
                MessageBox.Show("Completar el campo Modelo", "Validación", MessageBoxButtons.OKCancel);
                Modelotxt.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Preciotxt.Text) || Preciotxt.Text == "0.00")
            {
                MessageBox.Show("Completar el campo Precio. Este debe de ser mayor que 0.00", "Validación", MessageBoxButtons.OKCancel);
                Preciotxt.Focus();
                paso = false;
            }
            else if (tipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un tipo de vehiculo", "Validación", MessageBoxButtons.OKCancel);
                tipoCmb.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(aniotxt.Text))
            {
                MessageBox.Show("Complete el anio", "Validación", MessageBoxButtons.OKCancel);
                tipoCmb.Focus();
                paso = false;
            }
            return paso;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;

                actualizar = $"EXEC sp_ModificarVehiculos {Idtxt.Text}, '{Modelotxt.Text}', {marcaCbm.SelectedIndex + 1}, {combustiblecmb.SelectedIndex + 1}, {Preciotxt.Text}, {cantidadnumeric.Value}, {colorcmb.SelectedIndex + 1}, {aniotxt.Text}, {tipoCmb.SelectedIndex + 1}";


                OleDbCommand datos = new OleDbCommand(actualizar, cnn);
                cnn.Open();

                datos.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Vehiculo modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                actualizar = "EXEC sp_EliminarVehiculos " + Idtxt.Text;
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Vehiculo eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Modelotxt.Enabled = false;
            Preciotxt.Enabled = false;
            tipoCmb.Enabled = false;
            tipoCmb.Enabled = false;
            marcaCbm.Enabled = false;
            combustiblecmb.Enabled = false;
            colorcmb.Enabled = false;
            cantidadnumeric.Enabled = false;
        }
    }
}
