using CrystalDecisions.CrystalReports.Engine;
using DealerSystempt2.Conexion;
using DealerSystempt2.UI.Reportes;
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
    public partial class cVentaVehiculos : Form
    {

        Connection conexion;
        OleDbConnection cnn;
        public cVentaVehiculos()
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
            string query1 = "EXEC sp_ConsultarVentasVehiculos " + (filtrocmb.SelectedIndex + 1) + ", " + criterio;
            SqlDataAdapter da2 = new SqlDataAdapter(query1, conexion.Conectar());

            DataTable dt = new DataTable();

            da2.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ConsultaDTG.Rows.Add(dr["VentaId"].ToString(), dr["Fecha"].ToString(), dr["Tipo"].ToString(), dr["Total"].ToString());
            }
        }

        private void Imprimirbtn_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(@"C:\Users\jimen\source\repos\DealerSystempt2\UI\Reportes\ListadoVentas.rpt");
            ImprimirReportes reporte = new ImprimirReportes(reportDocument);
            reporte.Show();
        }
    }
}
