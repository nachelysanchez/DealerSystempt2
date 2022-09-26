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
    public partial class rVentas : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        public static float cantidad = 0;
        public rVentas()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = BRIAN-PC\BRIANSQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";
            Nuevo();

        }

        public void Nuevo()
        {
            Idtxt.Clear();
            ClienteIdtxt.Clear();
            NombreCliente.Clear();
            tipocmb.SelectedIndex = -1;
            FechaDatePicker.Text = DateTime.Now.ToString();
            VehiculoIdtxt.Clear();
            Descripciontxt.Clear();
            Cantidadtxt.Clear();
            Preciotxt.Clear();
            Importetxt.Clear();
            DetalleDTG.Rows.Clear();
            SubTotaltxt.Clear();
            ITBIStxt.Clear();
            Descuentotxt.Clear();
            Totaltxt.Clear();
        }

        public void NuevoParaBuscar()
        {
            ClienteIdtxt.Clear();
            NombreCliente.Clear();
            tipocmb.SelectedIndex = -1;
            FechaDatePicker.Text = DateTime.Now.ToString();
            VehiculoIdtxt.Clear();
            Descripciontxt.Clear();
            Cantidadtxt.Clear();
            Preciotxt.Clear();
            Importetxt.Clear();
            DetalleDTG.Rows.Clear();
            SubTotaltxt.Clear();
            ITBIStxt.Clear();
            Descuentotxt.Clear();
            Totaltxt.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Cantidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (ValidadDetalle())
                {
                    double Cantidad = ConvertToDouble(Cantidadtxt.Text);
                    double Precio = ConvertToDouble(Preciotxt.Text);
                    double SubTotal = (Cantidad * Precio);
                    double ITBIS =  SubTotal * 0.18;
                    double Importe = SubTotal + ITBIS;
                    if (cantidad < int.Parse(Cantidadtxt.Text))
                    {
                        MessageBox.Show("No puede vender más de la cantidad existente\n\n Este accesorio tiene " + cantidad + " unidades disponibles", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {

                        DetalleDTG.Rows.Add(VehiculoIdtxt.Text,Descripciontxt.Text, Cantidad.ToString("N2"), Precio.ToString("N2"), ITBIS.ToString("N2"), Importe.ToString("N2"));

                        SubTotaltxt.Text = (ConvertToDouble(SubTotaltxt.Text) + SubTotal).ToString("N2");
                        ITBIStxt.Text = (ConvertToDouble(ITBIStxt.Text) + ITBIS).ToString("N2");
                        Totaltxt.Text = (ConvertToDouble(SubTotaltxt.Text) + ConvertToDouble(ITBIStxt.Text)).ToString("N2");

                    }
                    VehiculoIdtxt.Clear();
                    Descripciontxt.Clear();
                    Cantidadtxt.Clear();
                    Preciotxt.Clear();
                    Importetxt.Clear();
                }
            }
        }

        private bool ValidadDetalle()
        {
            if (string.IsNullOrWhiteSpace(VehiculoIdtxt.Text))
            {
                MessageBox.Show("Debe seleccionar un Vehículo", "Validación", MessageBoxButtons.OKCancel);
                VehiculoIdtxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(Cantidadtxt.Text))
            {
                MessageBox.Show("Debe añadir una cantidad", "Validación", MessageBoxButtons.OKCancel);
                VehiculoIdtxt.Focus();
                return false;
            }
            return true;
        }

        private double ConvertToDouble(string valor)
        {
            if (valor == null)
            {
                return 0;
            }
            else
            {
                double OutVal;
                double.TryParse(valor, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {

            string query = $"EXEC sp_BuscarCliente {ClienteIdtxt.Text}";

            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());
            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    ClienteIdtxt.Text = dr1["ClienteId"].ToString();
                    NombreCliente.Text = dr1["Nombres"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
                NombreCliente.Clear();
            }
            


            if (dr1 != null)
            {
                dr1.Close();
            }
        }

        private void Cantidadtxt_TextChanged(object sender, EventArgs e)
        {
            double Cantidad = ConvertToDouble(Cantidadtxt.Text);
            double Precio = ConvertToDouble(Preciotxt.Text);
            Importetxt.Text = (Cantidad * Precio).ToString("N2");
        }

        private void BuscarVehiculoButton_Click(object sender, EventArgs e)
        {
            string query = $"EXEC sp_BuscarVehiculos {VehiculoIdtxt.Text}";

            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());
            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    cantidad = int.Parse(dr1["Existencia"].ToString());
                    if (cantidad > 0)
                    {
                        VehiculoIdtxt.Text = dr1["VehiculoId"].ToString();
                        Descripciontxt.Text = dr1["Modelo"].ToString();
                        Preciotxt.Text = dr1["Precio"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No puede vender este vehiculo. No tiene existencia", "Error", MessageBoxButtons.OK);
                        dr1.Close();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vehiculo no encontrado");
                NombreCliente.Clear();
            }



            if (dr1 != null)
            {
                dr1.Close();
            }
        }

        private void Descuentotxt_TextChanged(object sender, EventArgs e)
        {
            double Descuento = ConvertToDouble(Descuentotxt.Text);
            Totaltxt.Text = ((ConvertToDouble(SubTotaltxt.Text) + ConvertToDouble(ITBIStxt.Text)) - Descuento).ToString("N2");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertarEVenta '{FechaDatePicker.Value.ToString("yyyy/MM/dd")}', {tipocmb.SelectedIndex}, '{ClienteIdtxt.Text}', {ITBIStxt.Text.Replace(",","")}, {SubTotaltxt.Text.Replace(",", "")}, {Descuentotxt.Text.Replace(",", "")}, {Totaltxt.Text.Replace(",", "")},{Totaltxt.Text.Replace(",", "")}";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Ventas guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuardarDetalle();
                Nuevo();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private int getUltimaVenta()
        {
            int id1 = 0;
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT top(1) VentaId FROM eVentas Order by VentaId desc";

                SqlCommand command = new SqlCommand(query, conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                int id = int.Parse(dt.Rows[0]["VentaId"].ToString());
                id1 = id;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido una excepción");
            }
            return id1;
        }
        private void GuardarDetalle()
        {
            string insert;
            try
            {
                int id = getUltimaVenta();
                foreach (DataGridViewRow row in DetalleDTG.Rows)
                {
                    int VehiculoId = int.Parse(row.Cells["VehiculoIdColumn"].Value.ToString());
                    decimal cantidad = decimal.Parse(row.Cells["CantidadColumn"].Value.ToString());
                    decimal precio = decimal.Parse(row.Cells["PrecioColumn"].Value.ToString());
                    decimal itbis = decimal.Parse(row.Cells["ITBISColumn"].Value.ToString());
                    decimal importe = decimal.Parse(row.Cells["ImporteColumn"].Value.ToString());
                    insert = $"EXEC dbo.sp_InsertarDVenta {id}, {VehiculoId},{cantidad}, {precio},{itbis},{importe}";


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

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(NombreCliente.Text))
            {
                MessageBox.Show("Debe de buscar un cliente", "Validación", MessageBoxButtons.OKCancel);
                ClienteIdtxt.Focus();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NuevoParaBuscar();
            string query = "EXEC sp_BuscarEVenta " + Idtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();

            while (dr1.Read())
            {
                ClienteIdtxt.Text = dr1["ClienteId"].ToString();
                tipocmb.SelectedIndex = int.Parse(dr1["Tipo"].ToString()) - 1;
                FechaDatePicker.Value = DateTime.Parse(dr1["Fecha"].ToString());
                SubTotaltxt.Text = dr1["Subtotal"].ToString();
                ITBIStxt.Text = dr1["Itbis"].ToString();
                Descuentotxt.Text = dr1["Descuento"].ToString();
                Totaltxt.Text = dr1["Total"].ToString();

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
            BuscarClienteButton.PerformClick();


            string query1 = "EXEC sp_BuscarDVenta " + Idtxt.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(query1, conexion.Conectar());

            DataTable dt = new DataTable();

            da2.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                DetalleDTG.Rows.Add(dr["VehiculoId"].ToString(), dr["Descripcion"].ToString(), dr["Cantidad"].ToString(), dr["Precio"].ToString(), dr["ITBIS"].ToString(), dr["Importe"].ToString());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string actualizar;
                actualizar = "EXEC sp_EliminarEVentas " + Idtxt.Text;
                cnn.Open();
                OleDbCommand datos = new OleDbCommand(actualizar, cnn);

                datos.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Venta eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Nuevo();
        }
    }
}
