using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea3
{
    class Conexion
    {
        public string servidor, db;
        public bool security;
        public string cadena;

        public void Conectar()
        {
            servidor = @"LAPTOP-TN73JHLV\SQLEXPRESS";
            db = "DB_Sucarnet";
            security = true;
            cadena = "Server = " + servidor + "; Initial Catalog = " + db + ";Integrated Security = " + security;
        }
    }
}
