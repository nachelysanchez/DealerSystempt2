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
        public rVentas()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = LAPTOP-TN73JHLV\SQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";
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

                    DetalleDTG.Rows.Add(VehiculoIdtxt.Text,Descripciontxt.Text, Cantidad.ToString("N2"), Precio.ToString("N2"), ITBIS.ToString("N2"), Importe.ToString("N2"));

                    SubTotaltxt.Text = (ConvertToDouble(SubTotaltxt.Text) + SubTotal).ToString("N2");
                    ITBIStxt.Text = (ConvertToDouble(ITBIStxt.Text) + ITBIS).ToString("N2");
                    Totaltxt.Text = (ConvertToDouble(SubTotaltxt.Text) + ConvertToDouble(ITBIStxt.Text)).ToString("N2");

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
                    VehiculoIdtxt.Text = dr1["VehiculoId"].ToString();
                    Descripciontxt.Text = dr1["Modelo"].ToString();
                    Preciotxt.Text = dr1["Precio"].ToString();
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
            double Total = ConvertToDouble(Totaltxt.Text);
            Totaltxt.Text = (Total - Descuento).ToString("N2");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                string inserpart;

                inserpart = $"EXEC sp_InsertarEVenta '{FechaDatePicker.Value.ToLongDateString()}', {tipocmb.SelectedIndex}, '{ClienteIdtxt.Text}', {ITBIStxt.Text}, {SubTotaltxt.Text}, {Descuentotxt.Text}, {Totaltxt.Text},{Totaltxt.Text}";
                SqlCommand insert1 = new SqlCommand(inserpart, conexion.Conectar());


                insert1.ExecuteNonQuery();

                MessageBox.Show("Ventas guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool Validar()
        {
            //if (string.IsNullOrEmpty(NombresTextBox.Text))
            //{
            //    MessageBox.Show("Completar el campo Nombres", "Validación", MessageBoxButtons.OKCancel);
            //    NombresTextBox.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(ApellidosTextBox.Text))
            //{
            //    MessageBox.Show("Completar el campo Apellidos", "Validación", MessageBoxButtons.OKCancel);
            //    ApellidosTextBox.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(TelefonoTextBox.Text))
            //{
            //    MessageBox.Show("Completar el campo Teléfono", "Validación", MessageBoxButtons.OKCancel);
            //    TelefonoTextBox.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(CedulaTextBox.Text))
            //{
            //    MessageBox.Show("Completar el campo Cédula", "Validación", MessageBoxButtons.OKCancel);
            //    CedulaTextBox.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(CelularTextBox.Text))
            //{
            //    MessageBox.Show("Completar el campo Celular", "Validación", MessageBoxButtons.OKCancel);
            //    CelularTextBox.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(OcupacionTextBox.Text))
            //{
            //    MessageBox.Show("Completar el campo Ocupación", "Validación", MessageBoxButtons.OKCancel);
            //    OcupacionTextBox.Focus();
            //    return false;
            //}
            return true;
        }
    }
}
