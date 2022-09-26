using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Maritimo : Vehiculo
    {
        private int numeroHelices;

        public int NumeroHelices
        {
            set
            {
                numeroHelices = value;
            }
            get
            {
                return numeroHelices;
            }
        }
    }
}
