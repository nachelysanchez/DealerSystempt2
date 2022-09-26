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
    public partial class rCarro : VehiculoGeneralFrm
    {
        Carro carro;
        public rCarro()
        {
            InitializeComponent();
        }

        private void rCarro_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            carro = new Carro(marcaTextBox.Text, int.Parse(anioTextBox.Text), placaTextBox.Text,
                            combustibleTextBox.Text, int.Parse(numRuedastxt.Text), int.Parse(numPuertastxt.Text), false);

            foreach (var dato in carro.Carros)
            {
                if (dato.Placa == placaTextBox.Text)
                {
                    MessageBox.Show("La placa ingresada ya existe");
                    placaTextBox.Focus();
                    return;
                }
            }

            carro.Carros.Add(carro);
            MessageBox.Show("Vehiculo creado", "Exito", MessageBoxButtons.OK);
        }

        private bool Validar()
        {
            bool paso = true;
            if (marcaTextBox.Text == string.Empty || marcaTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar una marca");
                paso = false;
                marcaTextBox.Focus();
            }
            else if (anioTextBox.Text == string.Empty || marcaTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar un año de creación");
                paso = false;
                anioTextBox.Focus();
            }
            else if (placaTextBox.Text == string.Empty || placaTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar una placa");
                paso = false;
                placaTextBox.Focus();
            }
            else if (combustibleTextBox.Text == string.Empty || combustibleTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar un tipo de combustible");
                paso = false;
                combustibleTextBox.Focus();
            }
            else if (numPuertastxt.Text == string.Empty || numPuertastxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar un numero de puertas");
                paso = false;
                numPuertastxt.Focus();
            }
            else if (numRuedastxt.Text == string.Empty || numRuedastxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar un numero de ruedas");
                paso = false;
                numRuedastxt.Focus();
            }
            return paso;
        }
    }
}
