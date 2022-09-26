using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Terrestre : Vehiculo
    {
        private int numeroPuertas;


        public int NumeroPuertas
        {
            set
            {
                numeroPuertas = value;
            }
            get
            {
                return numeroPuertas;
            }
        }
    }
}
