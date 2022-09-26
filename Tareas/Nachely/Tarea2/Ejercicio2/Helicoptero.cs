using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Helicoptero : Aereo
    {
        private static List<Helicoptero> helicopteros = new List<Helicoptero>();
        private double velocidad;

        public List<Helicoptero> Helicopteros
        {
            get
            {
                return helicopteros;
            }
            set
            {
                helicopteros = value;
            }
        }

        public double Velocidad
        {
            set
            {
                velocidad = value;
            }
            get
            {
                return velocidad;
            }
        }

        public Helicoptero()
        {

        }

        public Helicoptero(string marca, int anio, string placa, string combustible, int numeroAlas, double velocidad, bool ocupado)
        {
            Marca = marca;
            Anio = anio;
            Placa = placa;
            Combustible = combustible;
            NumeroAlas = numeroAlas;
            Velocidad = velocidad;
            Ocupado = ocupado;
        }
    }
}
