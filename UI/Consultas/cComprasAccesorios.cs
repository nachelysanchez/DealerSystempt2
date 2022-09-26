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

namespace DealerSystempt2.UI.Consultas
{
    public partial class cComprasAccesorios : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        public cComprasAccesorios()
        {
            InitializeComponent();
            MaximizeBox = false;
            conexion = new Connection();
            cnn = new OleDbConnection();
            cnn.ConnectionString = @"PROVIDER = SQLOLEDB; Data Source = BRIAN-PC\BRIANSQLEXPRESS; Initial Catalog = DealerSystem; Integrated Security=SSPI;";

            filtrocmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaDTG.Rows.Clear();
            string criterio = string.Empty;
            if (string.IsNullOrEmpty(Criteriotxt.Text))
            {
                criterio = "na";
            }
            else
            {
                criterio = Criteriotxt.Text;
            }
            string query1 = "EXEC sp_ConsultarComprasAccesorio " + (filtrocmb.SelectedIndex + 1) + ", " + criterio;
            SqlDataAdapter da2 = new SqlDataAdapter(query1, conexion.Conectar());

            DataTable dt = new DataTable();

            da2.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ConsultaDTG.Rows.Add(dr["CompraId"].ToString(), dr["Fecha"].ToString(), dr["Tipo"].ToString(), dr["Total"].ToString());
            }
        }
    }
}
