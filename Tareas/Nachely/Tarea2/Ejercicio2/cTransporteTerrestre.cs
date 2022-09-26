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
    public partial class cTransporteTerrestre : Form
    {
        public cTransporteTerrestre()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Carro carros = new Carro();
            foreach (var item in carros.Carros)
            {
                terrestresGrid.Rows.Add(item.Marca, item.Anio.ToString(), item.Placa, item.Combustible, item.NumeroRuedas.ToString(), item.NumeroPuertas.ToString(), item.Ocupado.ToString());
            }
        }
    }
}
