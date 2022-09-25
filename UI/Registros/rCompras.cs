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
    public partial class rCompras : Form
    {
        public static float subtotal = 0;
        public static float itbis = 0;
        public static float descuento = 0;
        public static float total = 0;

        Connection conexion;
        OleDbConnection cnn;
        //NACH
        public static string svname = @"LAPTOP-TN73JHLV\SQLEXPRESS";
        //BRIAN
        //public string svname = @"BRIAN-PC\BRIANSQLEXPRESS";
        public rCompras()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();

            Cancelar();

            cnn = new OleDbConnection();
            cnn.ConnectionString = $@"PROVIDER = SQLOLEDB; Data Source = {svname}; Initial Catalog = DealerSystem; Integrated Security=SSPI;";

        }
        private void Cancelar()
        {
            Idtxt.Enabled = true;
            Idtxt.ReadOnly = false;
            SuplidorIdtxt.Enabled = false;
            tipocmb.Enabled = false;
            FechaDatePicker.Enabled = false;
            AccesorioIstxt.Enabled = false;
            Cantidadtxt.Enabled = false;


            btnInsertar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_BuscareComprasAccesorios " + Idtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                SuplidorIdtxt.Text = dr1["SuplidorId"].ToString();

                tipocmb.SelectedIndex = int.Parse(dr1["Tipo"].ToString()) - 1;
                FechaDatePicker.Value = DateTime.Parse(dr1["Fecha"].ToString());
                Subtotaltxt.Text = dr1["Subtotal"].ToString();
                itbistxt.Text = dr1["Itbis"].ToString();
                Descuentotxt.Text = dr1["Descuento"].ToString();
                totaltxt.Text = dr1["Total"].ToString();

            }
            if (dr1 != null)
            {
                dr1.Close();
                //HabilitarModificar();
            }
            else
            {
                dr1.Close();
            }
            BuscarSuplidor();


            string query1 = "EXEC sp_BuscardCompraAccesorio " + Idtxt.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(query1, conexion.Conectar());

            DataTable dt = new DataTable();

            da2.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                DetalleDTG.Rows.Add(item["AccesorioId"].ToString(), item["Descripcion"].ToString(), item["Cantidad"].ToString(), item["Precio"].ToString(), item["Importe"].ToString());
            }
            //DetalleDTG.DataSource = dt;
            CalculandoTotales();
            btnEliminar.Enabled = true;
        }

        private void BuscarSuplidor()
        {
            string query = "EXEC sp_BuscarSuplidor " + SuplidorIdtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                NombreSuplidorTxt.Text = dr1["SuplidorId"].ToString().Trim() + " - " + dr1["Nombre"].ToString().Trim();
                
            }
            dr1.Close();
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarSuplidor();
        }

        private void BuscarAccesorioButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Accesorios WHERE AccesorioId = " + AccesorioIstxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();
            if (dr1.HasRows != false)
            {
                while (dr1.Read())
                {
                    NombreAccesoriotxt.Text = AccesorioIstxt.Text + "-" + dr1["Nombre"].ToString().Trim();
                    Preciotxt.Text = dr1["Precio"].ToString().Trim();
                    //Importetxt.Text = (float.Parse(Preciotxt.Text)* float.Parse(Cantidadtxt.Text)).ToString();
                }
                if (dr1 != null)
                {
                    dr1.Close();
                }
            }
            else
            {
                MessageBox.Show("Accesorio no encontrado", "Busqueda", MessageBoxButtons.OK);
                dr1.Close();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertareCompraAccesorio '{FechaDatePicker.Value.ToShortDateString()}', {tipocmb.SelectedIndex + 1},{SuplidorIdtxt.Text} , {itbis}, {subtotal}, {descuento}, {total}, {total}";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                GuardarDetalle();

                MessageBox.Show("Compra guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(NombreSuplidorTxt.Text))
            {
                MessageBox.Show("Debe de buscar un suplidor", "Validación", MessageBoxButtons.OKCancel);
                SuplidorIdtxt.Focus();
                paso = false;
            }
            else if (tipocmb.SelectedIndex != 1 && tipocmb.SelectedIndex != 0)
            {
                MessageBox.Show("Selecciona un tipo", "Validación", MessageBoxButtons.OKCancel);
                tipocmb.Focus();
                paso = false;
            }
            return paso;
        }
        private void Nuevo()
        {
            Idtxt.ReadOnly = true;
            SuplidorIdtxt.Clear();
            NombreSuplidorTxt.Clear();
            FechaDatePicker.Value = DateTime.Now;
            Cantidadtxt.Clear();
            AccesorioIstxt.Clear();
            NombreAccesoriotxt.Clear();

            //tipoCmb.SelectedIndex = 0;
            Idtxt.Enabled = true;
            SuplidorIdtxt.Enabled = true;
            FechaDatePicker.Enabled = true;
            AccesorioIstxt.Enabled = true;
            tipocmb.Enabled = true;
            Cantidadtxt.Enabled = true;
            btnEliminar.Enabled = false;
            btnInsertar.Enabled = true;
            DetalleDTG.Rows.Clear();
            Subtotaltxt.Clear();
            itbistxt.Clear();
            Descuentotxt.Text = "0.00";
            totaltxt.Clear();
        }

        private void GuardarDetalle()
        {
            string insert;
            try
            {
                int id = getUltimaCompra();
                foreach (DataGridViewRow row in DetalleDTG.Rows)
                {
                    int accesorioId = int.Parse(row.Cells["AccesorioId"].Value.ToString());
                    string descripcion = row.Cells["Accesorio"].Value.ToString();
                    int cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    float precio = float.Parse(row.Cells["Precio"].Value.ToString());
                    float importe = float.Parse(row.Cells["Importe"].Value.ToString());
                    insert = $"EXEC dbo.sp_InsertardComprasAccesorio {id}, {accesorioId}, '{descripcion}',{cantidad}, {precio}, {importe}";


                    SqlCommand insert1 = new SqlCommand(insert, conexion.Conectar());


                    insert1.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción");
                throw;
            }
        }

        private int getUltimaCompra()
        {
            int id1 = 0;
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT top(1) CompraId FROM eComprasAccesorios Order by CompraId desc";

                SqlCommand command = new SqlCommand(query, conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                int id = int.Parse(dt.Rows[0]["CompraId"].ToString());
                id1 = id;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción");
            }
            return id1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;
                actualizar = "EXEC sp_EliminareComprasAccesorios " + Idtxt.Text;
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Compra eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Cantidadtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidarDetalle())
                {
                    return;
                }
                DetalleDTG.Rows.Add(AccesorioIstxt.Text, NombreAccesoriotxt.Text, Cantidadtxt.Text, Preciotxt.Text, (float.Parse(Preciotxt.Text) * int.Parse(Cantidadtxt.Text)).ToString("N2"));
                CalculandoTotales();
                LimpiarDetalle();
            }
        }
        private void LimpiarDetalle()
        {
            NombreAccesoriotxt.Clear();
            Preciotxt.Clear();
            AccesorioIstxt.Clear();
            Cantidadtxt.Clear();
        }
        private bool ValidarDetalle()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(NombreAccesoriotxt.Text))
            {
                MessageBox.Show("Debe de buscar un accesorio", "Validación", MessageBoxButtons.OKCancel);
                AccesorioIstxt.Focus();
                paso = false;
            }
            else if (string.IsNullOrEmpty(Cantidadtxt.Text))
            {
                MessageBox.Show("Debe de ingresar una cantidad a vender", "Validación", MessageBoxButtons.OKCancel);
                Cantidadtxt.Focus();
                paso = false;
            }
            return paso;
        }
        private void CalculandoTotales()
        {
            subtotal = 0;
            itbis = 0;
            descuento = float.Parse(Descuentotxt.Text);
            total = 0;
            foreach (DataGridViewRow row in DetalleDTG.Rows)
            {
                subtotal += float.Parse(row.Cells["Importe"].Value.ToString());
                itbis += (subtotal * 18 / 100);

                total += (itbis + subtotal - descuento);


            }
            Subtotaltxt.Text = subtotal.ToString("N2");
            itbistxt.Text = itbis.ToString("N2");
            totaltxt.Text = total.ToString("N2");

        }

        private void Descuentotxt_TextChanged(object sender, EventArgs e)
        {
            CalculandoTotales();
        }
    }
}
