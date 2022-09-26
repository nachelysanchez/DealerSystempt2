using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Guias.Nachely.Clase4
{
    public partial class cCiudades : Form
    {
        private SqlConnection cnn;
        private SqlCommand insert;
        private string sCn;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public cCiudades()
        {
            InitializeComponent();
            Conexion con = new Conexion();
            con.conec();
            sCn = con.cadena;
            cnn = new SqlConnection(sCn);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(sCn);
            DataTable dt = new DataTable();

            if (filtrotxt.Text.Trim().Length > 0)
            {
                if (comboFiltro.SelectedIndex == 1)
                {
                    using (cnn)
                    {
                        string query = $"SELECT id_Ciudad AS 'Id Ciudad', NombreCiudad AS 'Nombre' FROM CIUDADES WHERE {comboFiltro.Text} like '%{filtrotxt.Text}%'";

                        SqlCommand command = new SqlCommand(query, cnn);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                    }
                    ciudadesdtg.DataSource = dt;

                }
                else
                {
                    using (cnn)
                    {
                        string query = $"SELECT id_Ciudad AS 'Id Ciudad', NombreCiudad AS 'Nombre' FROM CIUDADES WHERE {comboFiltro.Text} = {filtrotxt.Text}";

                        SqlCommand command = new SqlCommand(query, cnn);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                    }
                    ciudadesdtg.DataSource = dt;

                }
            }
            else
            {
                using (cnn)
                {
                    string query = $"SELECT id_Ciudad AS 'Id Ciudad', NombreCiudad AS 'Nombre' FROM CIUDADES";

                    SqlCommand command = new SqlCommand(query, cnn);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                }
                ciudadesdtg.DataSource = dt;
            }
        }
    }
}
