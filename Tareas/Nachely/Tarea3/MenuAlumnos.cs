using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Tareas.Nachely.Tarea3
{
    public partial class MenuAlumnos : Form
    {
        public MenuAlumnos()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes es = new rEstudiantes();
            es.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMaterias materias = new rMaterias();
            materias.Show();
        }
    }
}
