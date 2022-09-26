using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Guias.Nachely.Clase2.Ejemplo2
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EstudiantesButton_Click(object sender, EventArgs e)
        {
            EstudiantesForm es = new EstudiantesForm();
            es.Show();
        }

        private void DocentesButton_Click(object sender, EventArgs e)
        {
            DocentesForm doc = new DocentesForm();
            doc.Show();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            FormSalir salir = new FormSalir();
            salir.Show();
        }

        private void RegistroButton_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            registro.Show();
        }
    }
}
