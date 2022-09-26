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
    public partial class cUsuarios : Form
    {
        private SqlConnection cnn;
        private SqlCommand insert;
        private string sCn;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public cUsuarios()
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
                        string query = $"SELECT id_Usuario AS 'Id Usuario', NombreUsuario AS 'Nombres', usuario AS 'Nombre de Usuario', '' AS 'Contraseña', IIF(activo != 0, 'Si', 'No') AS 'Estado', c.NombreCiudad AS 'Ciudad' FROM USUARIOS AS u INNER JOIN CIUDADES AS c on c.id_Ciudad = u.id_Ciudad WHERE {comboFiltro.Text} like '%{filtrotxt.Text}%'";

                        SqlCommand command = new SqlCommand(query, cnn);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                    }
                    usuariosdtg.DataSource = dt;

                }
                else
                {
                    using (cnn)
                    {
                        string query = $"SELECT id_Usuario AS 'Id Usuario', NombreUsuario AS 'Nombres', usuario AS 'Nombre de Usuario', '' AS 'Contraseña', IIF(activo != 0, 'Si', 'No') AS 'Estado', c.NombreCiudad AS 'Ciudad' FROM USUARIOS AS u INNER JOIN CIUDADES AS c on c.id_Ciudad = u.id_Ciudad WHERE {comboFiltro.Text} = {filtrotxt.Text}";

                        SqlCommand command = new SqlCommand(query, cnn);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        da.Fill(dt);
                    }
                    usuariosdtg.DataSource = dt;

                }
            }
            else
            {
                using (cnn)
                {
                    string query = $"SELECT id_Usuario AS 'Id Usuario', NombreUsuario AS 'Nombres', usuario AS 'Nombre de Usuario', '' AS 'Contraseña', IIF(activo != 0, 'Si', 'No') AS 'Estado', c.NombreCiudad AS 'Ciudad' FROM USUARIOS AS u INNER JOIN CIUDADES AS c on c.id_Ciudad = u.id_Ciudad ";

                    SqlCommand command = new SqlCommand(query, cnn);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                }
                usuariosdtg.DataSource = dt;
            }
        }
    }
}
