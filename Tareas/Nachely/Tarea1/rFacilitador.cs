using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Tareas.Nachely.Tarea1
{
    public partial class rFacilitador : Form
    {
        public rFacilitador()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            claUAPA em = new claUAPA(1, "Nachely", "809-999-8966", "Programacion");

            EmpleadoText.Text = em.ToString();
        }
    }
}
