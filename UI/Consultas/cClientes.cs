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
using CrystalDecisions.CrystalReports.Engine;
using DealerSystempt2.UI.Reportes;

namespace DealerSystempt2.UI.Consultas
{
    public partial class cClientes : Form
    {
        Connection conexion;
        OleDbConnection cnn;
        public cClientes()
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
            if (string.IsNullOrEmpty(Criteriotxt.Text)){
                criterio = "na"; 
            }
            else
            {
                criterio = Criteriotxt.Text;
            } 
            string query1 = "EXEC sp_ConsultarClientes " + (filtrocmb.SelectedIndex+1) + ", " + criterio;
            SqlDataAdapter da2 = new SqlDataAdapter(query1, conexion.Conectar());

            DataTable dt = new DataTable();

            da2.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ConsultaDTG.Rows.Add(dr["ClienteId"].ToString(), dr["Nombres"].ToString(), dr["Apellidos"].ToString(), dr["Telefono"].ToString(), dr["Cedula"].ToString(), dr["Ocupacion"].ToString());
            }

        }

    }
}
