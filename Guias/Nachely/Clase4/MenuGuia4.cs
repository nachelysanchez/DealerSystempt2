using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Guias.Nachely.Clase4
{
    public partial class MenuGuia4 : Form
    {
        public MenuGuia4()
        {
            InitializeComponent();
        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            Registro1 registro = new Registro1();
            registro.Show();
        }

        private void PedidosButton_Click(object sender, EventArgs e)
        {
            rPedidos pedidos = new rPedidos();
            pedidos.Show();
        }
    }
}
