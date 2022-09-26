using DealerSystempt2.Guias.Nachely.Clase1;
using DealerSystempt2.Guias.Nachely.Clase2.Ejemplo1;
using DealerSystempt2.Guias.Nachely.Clase2.Ejemplo2;
using DealerSystempt2.Guias.Nachely.Clase3;
using DealerSystempt2.Guias.Nachely.Clase4;
using DealerSystempt2.Tareas.Nachely.Tarea1;
using DealerSystempt2.Tareas.Nachely.Tarea2;
using DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2;
using DealerSystempt2.Tareas.Nachely.Tarea3;
using DealerSystempt2.Tareas.Nachely.Tarea4;
using DealerSystempt2.UI.Consultas;
using DealerSystempt2.UI.Login;
using DealerSystempt2.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealerSystempt2.UI.Registros.rUsuarios user = new DealerSystempt2.UI.Registros.rUsuarios();
            user.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes cliente = new rClientes();
            cliente.Show();
        }

        private void vehiculosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rVehiculos vehiculo = new rVehiculos();
            vehiculo.Show();
        }

        private void accesoriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rAccesorios accesorios = new rAccesorios();
            accesorios.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas ventas = new rVentas();
            ventas.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rSuplidores suplidor = new rSuplidores();
            suplidor.Show();
        }

        private void ventasDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentasAccesorios vaccesorios = new rVentasAccesorios();
            vaccesorios.Show();
        }

        private void comprasDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCompras compras = new rCompras();
            compras.Show();
        }

        private void comprasDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rComprasVehiculos cvehiculos = new rComprasVehiculos();
            cvehiculos.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cClientes clientes = new cClientes();
            clientes.Show();
        }

        private void accesoriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAccesorios accesorios = new cAccesorios();
            accesorios.Show();
        }

        private void compraDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cComprasAccesorios accesorios = new cComprasAccesorios();
            accesorios.Show();
        }

        private void compraDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cComprasVehiculos vehiculos = new cComprasVehiculos();
            vehiculos.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cSuplidores suplidores = new cSuplidores();
            suplidores.Show();
        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cVehiculos vehiculos = new cVehiculos();
            vehiculos.Show();
        }

        private void ventaDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVentasAccesorios accesorios = new cVentasAccesorios();
            accesorios.Show();
        }

        private void ventaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVentaVehiculos cVenta = new cVentaVehiculos();
            cVenta.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rCompras compras = new rCompras();
            compras.Show();
        }

        private void compraVehiculosLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rComprasVehiculos rCompras = new rComprasVehiculos();
            rCompras.Show();
        }

        private void VentaAccesoriosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rVentasAccesorios venta = new rVentasAccesorios();
            venta.Show();
        }

        private void VentasVehiculosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rVentas venta = new rVentas();
            venta.Show();
        }

        private void ClienteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rClientes cliente = new rClientes();
            cliente.Show();
        }

        private void SuplidorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rSuplidores suplidores = new rSuplidores();
            suplidores.Show();
        }

        private void UsuarioLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DealerSystempt2.UI.Registros.rUsuarios usuarios = new DealerSystempt2.UI.Registros.rUsuarios();
            usuarios.Show();
        }

        private void desarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrolladores:\n\nDesarrolladora Principal: Nachely Sánchez 100046842\nSegundo desarrollador: Juan Manuel Rodriguez");
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea cerrar sesión?", "Ventana principal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new Login().Show();
                this.Close();
            }
        }

        

        private void tarea1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFacilitador fa = new rFacilitador();
            fa.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rEmpleado em = new rEmpleado();
            em.Show();
        }

        private void ejemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora cal = new Calculadora();
            cal.Show();
        }

        private void ejemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm main = new MenuForm();
            main.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rNomina nomina = new rNomina();
            nomina.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVehiculo menu = new MenuVehiculo();
            menu.Show();
        }

        private void guia3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal3 menu = new Principal3();
            menu.Show();
        }

        private void tarea3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAlumnos alumnos = new MenuAlumnos();
            alumnos.Show();
        }

        private void guia4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuGuia4 menu = new MenuGuia4();
            menu.Show();
        }

        private void tarea4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuTarea4 tarea = new MenuTarea4();
            tarea.Show();
        }

        private void tarea6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informacion", "El login del presente proyecto es la prueba de esta tarea de acceso de datos");
        }

        private void tarea7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informacion", "El login y el modificar del presente proyecto es la prueba de esta tarea");
        }
    }
}
