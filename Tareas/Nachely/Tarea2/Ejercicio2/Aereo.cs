using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Aereo : Vehiculo
    {
        private int numeroAlas;
        public int NumeroAlas
        {
            set
            {
                numeroAlas = value;
            }
            get
            {
                return numeroAlas;
            }
        }
    }
}
