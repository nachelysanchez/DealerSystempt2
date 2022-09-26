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
    public partial class ReservaVehiculo : Form
    {
        Lancha lancha = new Lancha();
        Helicoptero helicoptero = new Helicoptero();
        Carro carro = new Carro();
        public ReservaVehiculo()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            vehiculosGrid.Rows.Clear();
            if (vehiculocombo.SelectedIndex == 0)
            {
                foreach (var item in lancha.Lanchas)
                {
                    vehiculosGrid.Rows.Add(item.Marca, item.Anio.ToString(), item.Placa, item.Combustible, item.Ocupado.ToString());
                }
            }
            else if (vehiculocombo.SelectedIndex == 1)
            {

                foreach (var item in helicoptero.Helicopteros)
                {
                    vehiculosGrid.Rows.Add(item.Marca, item.Anio.ToString(), item.Placa, item.Combustible, item.Ocupado.ToString());
                }
            }
            else if (vehiculocombo.SelectedIndex == 2)
            {

                foreach (var item in carro.Carros)
                {
                    vehiculosGrid.Rows.Add(item.Marca, item.Anio.ToString(), item.Placa, item.Combustible, item.Ocupado.ToString());
                }
            }
        }

        private void ReservarButton_Click(object sender, EventArgs e)
        {
            int rowindex = vehiculosGrid.CurrentCell.RowIndex;
            if (vehiculocombo.SelectedIndex == 0)
            {
                if (lancha.Lanchas[rowindex].Ocupado != false)
                {
                    MessageBox.Show("Este vehiculo no está disponible, porque tiene una resevación");
                }
                else
                {
                    lancha.Lanchas[rowindex].Ocupado = true;
                    MessageBox.Show("Reservación guardada");
                }
            }
            else if (vehiculocombo.SelectedIndex == 1)
            {
                if (helicoptero.Helicopteros[rowindex].Ocupado != false)
                {
                    MessageBox.Show("Este vehiculo no está disponible, porque tiene una resevación");
                }
                else
                {
                    helicoptero.Helicopteros[rowindex].Ocupado = true;
                    MessageBox.Show("Reservación guardada");
                }
            }
            else if (vehiculocombo.SelectedIndex == 2)
            {
                if (carro.Carros[rowindex].Ocupado != false)
                {
                    MessageBox.Show("Este vehiculo no está disponible, porque tiene una resevación");
                }
                else
                {
                    carro.Carros[rowindex].Ocupado = true;
                    MessageBox.Show("Reservación guardada");
                }
            }
        }
    }
}
