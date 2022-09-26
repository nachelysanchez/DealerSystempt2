using DealerSystempt2.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.UI.Login
{
    public partial class Login : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        //Form1 principal;
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = BRIAN-PC\BRIANSQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";
            //principal = new Form1();
        }
        private bool Validar()
        {
            bool esValido = true;
            if (Usertxt.Text.Length == 0 || Passtxt.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("No puede Dejar campos vacios", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return esValido;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            string query = "EXEC sp_Login " + Usertxt.Text + ", " + Passtxt.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(query, conexion.Conectar());

            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                if (bool.Parse(dr1["Estado"].ToString()) == true)
                {
                    Form1 principal = new Form1();
                    principal.Show();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario desactivado", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (dr1.HasRows == false)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta.", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            dr1.Close();
        }
    }
}
