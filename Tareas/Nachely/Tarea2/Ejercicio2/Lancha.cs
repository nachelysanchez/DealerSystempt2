using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Lancha : Maritimo
    {
        private int tamanio;

        private static List<Lancha> lanchas = new List<Lancha>();

        public List<Lancha> Lanchas
        {
            get
            {
                return lanchas;
            }
            set
            {
                lanchas = value;
            }
        }

        protected int Tamanio
        {
            set
            {
                tamanio = value;
            }
            get
            {
                return tamanio;
            }
        }

        public Lancha()
        {
            Marca = "";
            Anio = 0;
            Placa = "";
            Combustible = "";
            NumeroHelices = 0;
            Tamanio = 0;
            Ocupado = false;
        }
        public Lancha(string marca, int anio, string placa, string combustible, int numeroHelices, int tamano, bool ocupado)
        {
            Marca = marca;
            Anio = anio;
            Placa = placa;
            Combustible = combustible;
            NumeroHelices = numeroHelices;
            Tamanio = tamano;
            Ocupado = ocupado;
        }
    }
}
