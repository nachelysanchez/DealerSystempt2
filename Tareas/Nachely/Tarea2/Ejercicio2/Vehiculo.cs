using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Vehiculo
    {
        private string marca;
        private int anio;
        private string placa;
        private string combustible;
        private bool ocupado;

        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public int Anio
        {
            set
            {
                anio = value;
            }
            get
            {
                return anio;
            }
        }
        public string Placa
        {
            set
            {
                placa = value;
            }
            get
            {
                return placa;
            }
        }
        public string Combustible
        {
            set
            {
                combustible = value;
            }
            get
            {
                return combustible;
            }
        }

        public bool Ocupado
        {
            set
            {
                ocupado = value;
            }
            get
            {
                return ocupado;
            }
        }
    }
}
