using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Guias.Nachely.Clase1
{
    public partial class rEmpleado : Form
    {
        public rEmpleado()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Empleados em = new Empleados();
            em.ModificarNombre("Juan");
            em.ModificarApellido("Perez");
            em.ModificarCargo("Director");
            em.ModificarDepartamento("Registro");
            em.ModificarSueldo((float)150000.00);
            em.ModificarDUI("em1");
            em.ModificarFecha("1/1/2022");

            EmpleadoText.Text = em.ToString();
        }
    }
}
