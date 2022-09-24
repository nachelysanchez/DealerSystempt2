using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.UI.Registros
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT *FROM dbo.Clientes WHERE ClienteId = '{ClienteIdTextBox.Text}'";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }

        private void Nuevo()
        {
            ClienteIdTextBox.Clear();
            NombresTextBox.Clear();
            ApellidosTextBox.Clear();
            CedulaTextBox.Clear();
            TelefonoTextBox.Clear();
            CelularTextBox.Clear();
            OcupacionTextBox.Clear();
        }
    }
}
