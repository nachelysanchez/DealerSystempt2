using DealerSystempt2.UI.Consultas;
using DealerSystempt2.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes cliente = new rClientes();
            cliente.Show();
        }

        private void vehiculosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rVehiculos vehiculo = new rVehiculos();
            vehiculo.Show();
        }

        private void accesoriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rAccesorios accesorios = new rAccesorios();
            accesorios.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas ventas = new rVentas();
            ventas.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rSuplidores suplidor = new rSuplidores();
            suplidor.Show();
        }

        private void ventasDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentasAccesorios vaccesorios = new rVentasAccesorios();
            vaccesorios.Show();
        }

        private void comprasDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCompras compras = new rCompras();
            compras.Show();
        }

        private void comprasDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rComprasVehiculos cvehiculos = new rComprasVehiculos();
            cvehiculos.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cClientes clientes = new cClientes();
            clientes.Show();
        }
    }
}
