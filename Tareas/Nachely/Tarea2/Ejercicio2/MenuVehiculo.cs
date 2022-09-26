using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    public partial class MenuVehiculo : Form
    {
        public MenuVehiculo()
        {
            InitializeComponent();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCarro carro = new rCarro();
            carro.Show();
        }

        private void lanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLanchas lanchas = new rLanchas();
            lanchas.Show();
        }

        private void helicopterosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAereo aereo = new rAereo();
            aereo.Show();
        }

        private void verTransportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTransporteTerrestre terrestre = new cTransporteTerrestre();
            terrestre.Show();
        }

        private void reservarUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaVehiculo reserva = new ReservaVehiculo();
            reserva.Show();
        }
    }
}
