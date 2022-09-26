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
    public partial class rLanchas : VehiculoGeneralFrm
    {
        Lancha lancha;
        public rLanchas()
        {
            InitializeComponent();
        }

        private void rLanchas_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            lancha = new Lancha(marcaTextBox.Text, int.Parse(anioTextBox.Text), placaTextBox.Text,
                combustibleTextBox.Text, int.Parse(numAlastxt.Text), int.Parse(Tamanotxt.Text), false);

            if (!Validar())
            {
                return;
            }


            foreach (var dato in lancha.Lanchas)
            {
                if (dato.Placa == placaTextBox.Text)
                {
                    MessageBox.Show("La placa ingresada ya existe");
                    placaTextBox.Focus();
                    return;
                }
            }

            lancha.Lanchas.Add(lancha);
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
                MessageBox.Show("Debe de ingresar un numero de helices");
                paso = false;
                numAlastxt.Focus();
            }
            else if (Tamanotxt.Text == string.Empty || Tamanotxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar el tamaño");
                paso = false;
                Tamanotxt.Focus();
            }
            return paso;
        }
    }
}
