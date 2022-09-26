using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Guias.Nachely.Clase2.Ejemplo1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar();
            restxt.Text = suma.operar(int.Parse(Valor1txt.Text), int.Parse(valor2txt.Text)).ToString();

        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            restxt.Text = resta.operar(int.Parse(Valor1txt.Text), int.Parse(valor2txt.Text)).ToString();

        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            Multiplicar mult = new Multiplicar();
            restxt.Text = mult.operar(int.Parse(Valor1txt.Text), int.Parse(valor2txt.Text)).ToString();

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Valor1txt.Clear();
            valor2txt.Clear();
            restxt.Clear();
        }
    }
}
