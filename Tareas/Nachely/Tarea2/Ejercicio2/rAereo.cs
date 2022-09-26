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
    public partial class rAereo : VehiculoGeneralFrm
    {
        Helicoptero helicoptero;
        public rAereo()
        {
            InitializeComponent();
        }

        private void rAereo_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            helicoptero = new Helicoptero(marcaTextBox.Text, int.Parse(anioTextBox.Text), placaTextBox.Text,
                combustibleTextBox.Text, int.Parse(numAlastxt.Text), int.Parse(Velocidadtxt.Text), false);

            if (!Validar())
            {
                return;
            }

            foreach (var dato in helicoptero.Helicopteros)
            {
                if (dato.Placa == placaTextBox.Text)
                {
                    MessageBox.Show("La placa ingresada ya existe");
                    placaTextBox.Focus();
                    return;
                }
            }

            helicoptero.Helicopteros.Add(helicoptero);
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
            else if (numAlastxt.Text == string.Empty || numAlastxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar un numero de alas");
                paso = false;
                numAlastxt.Focus();
            }
            else if (Velocidadtxt.Text == string.Empty || Velocidadtxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar a la velocidad que puede ir el vehiculo");
                paso = false;
                Velocidadtxt.Focus();
            }
            return paso;
        }
    }
}
