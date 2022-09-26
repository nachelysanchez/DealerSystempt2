using DealerSystempt2.Guias.Nachely.Clase4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Tareas.Nachely.Tarea4
{
    public partial class MenuTarea4 : Form
    {
        public MenuTarea4()
        {
            InitializeComponent();
        }

        private void CiudadesButton_Click(object sender, EventArgs e)
        {
            rCiudades ciudades = new rCiudades();
            ciudades.Show();
        }

        private void cCiudadesButton_Click(object sender, EventArgs e)
        {
            cCiudades ciudad = new cCiudades();
            ciudad.Show();
        }

        private void UsuariosButton_Click(object sender, EventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
        }

        private void cUsuariosButton_Click(object sender, EventArgs e)
        {
            cUsuarios user = new cUsuarios();
            user.Show();
        }
    }
}
