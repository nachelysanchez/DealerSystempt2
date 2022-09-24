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
    public partial class rAccesorios : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        public rAccesorios()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();

            Cancelar();

            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = BRIAN-PC\BRIANSQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            getUltimoAccesorio();
            Idtxt.ReadOnly = true;
            Nombretxt.Clear();
            Preciotxt.Clear();
            //tipoCmb.SelectedIndex = 0;
            Idtxt.Enabled = true;
            Nombretxt.Enabled = true;
            Preciotxt.Enabled = true;
            tipoCmb.Enabled = true;
            btnModificar.Enabled = false;
            btnInsertar.Enabled = true;
        }

        private void rAccesorios_Load(object sender, EventArgs e)
        {
            tipoCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            LlenarCombo();
        }
        public void LlenarCombo()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT TipoId, Nombre FROM dbo.TiposVehiculos";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion.Conectar());
            da.Fill(ds, "dbo.TiposVehiculos");
            tipoCmb.DataSource = ds.Tables[0].DefaultView;
            tipoCmb.ValueMember = "TipoId";
            tipoCmb.DisplayMember = "Nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Accesorios WHERE AccesorioId = " + Idtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                Nombretxt.Text = dr1["Nombre"].ToString().Trim();
                Preciotxt.Text = dr1["Precio"].ToString().Trim();
                tipoCmb.SelectedIndex = int.Parse(dr1["TipoId"].ToString()) - 1;
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
            Preciotxt.Enabled = true;
            tipoCmb.Enabled = true;
            btnModificar.Enabled = true;
            btnInsertar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        private void getUltimoAccesorio()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT top(1) AccesorioId FROM Accesorios Order by AccesorioId desc";

                SqlCommand command = new SqlCommand(query, conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Idtxt.Text = "1";
                }
                else
                {
                    int id = int.Parse(dt.Rows[0]["AccesorioId"].ToString());
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

                inserpart = "INSERT INTO dbo.Accesorios " +
                    $"VALUES ({Idtxt.Text}, '{Nombretxt.Text}', {Preciotxt.Text}, {tipoCmb.SelectedIndex + 1})";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Accesorio guardado", "Exito");
                //conn1.Close();
                Nuevo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comuniquese con los desarrolladores " + ex.Message, "Error");
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
            else if (string.IsNullOrEmpty(Preciotxt.Text))
            {
                MessageBox.Show("Completar el campo Precio", "Validación", MessageBoxButtons.OKCancel);
                Preciotxt.Focus();
                paso = false;
            }
            else if (tipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un tipo de vehiculo", "Validación", MessageBoxButtons.OKCancel);
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

                actualizar = "UPDATE dbo.Accesorios SET " +
                    "Nombre = '" + Nombretxt.Text + "', Precio = " + Preciotxt.Text + "" +
                    ", TipoId = " + (tipoCmb.SelectedIndex + 1) + " WHERE AccesorioId = " + Idtxt.Text;


                OleDbCommand datos = new OleDbCommand(actualizar, cnn);
                cnn.Open();

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Accesorio modificado", "Exito");
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
                actualizar = "DELETE FROM dbo.Accesorios WHERE AccesorioId=" + Idtxt.Text + "";
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("ELIMINADO");
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
            Preciotxt.Enabled = false;
            tipoCmb.Enabled = false;
            btnEliminar.Enabled = false;
            btnInsertar.Enabled = false;
            btnModificar.Enabled = false;
        }
    }
}
