using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerSystempt2.Conexion
{
    class Connection
    {
        private static string svnameNach = @"LAPTOP-TN73JHLV\SQLEXPRESS";
        private static string svnameBrian = @"BRIAN-PC\BRIANSQLEXPRESS";
        private static string dbname = "DealerSystem";

        private SqlDataAdapter dataAdapter;
        private SqlDataReader datareader;
        private SqlCommand command;
        private static string ConnectionString = "SERVER=" + svnameBrian + ";DATABASE=" + dbname + ";Integrated Security = True;";
        private SqlConnection Conexion = new SqlConnection(ConnectionString);


        public SqlDataAdapter DataAdapter { get => dataAdapter; set => dataAdapter = value; }
        public SqlDataReader DataReader { get => datareader; set => datareader = value; }
        public SqlCommand Command { get => command; set => command = value; }


        /// <summary>
        /// metodo para abrir la conexion a la DB
        /// </summary>
        /// <returns></returns>
        public SqlConnection Conectar()
        {

            if (Conexion.State == ConnectionState.Closed)
            {
                try
                {
                    Conexion.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return Conexion;
        }
        /// <summary>
        /// metodo para cerrar la conexion a la db
        /// </summary>
        /// <returns></returns>
        public SqlConnection Desconectar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                try
                {
                    Conexion.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo conectar a la DB.");
                    return null;
                }
            }
            return Conexion;
        }
    }
}
