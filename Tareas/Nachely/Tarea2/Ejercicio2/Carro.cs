using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    class Carro : Terrestre
    {
        private int numeroRuedas;
        private static List<Carro> carros = new List<Carro>();
        public List<Carro> Carros
        {
            set
            {
                carros = value;
            }
            get
            {
                return carros;
            }
        }
        public int NumeroRuedas
        {
            set
            {
                numeroRuedas = value;
            }
            get
            {
                return numeroRuedas;
            }
        }

        public Carro()
        {
            return;
        }
        public Carro(string marca, int anio, string placa, string combustible, int numeroRuedas, int numeroPuertas, bool ocupado)
        {
            Marca = marca;
            Anio = anio;
            Placa = placa;
            Combustible = combustible;
            NumeroRuedas = numeroRuedas;
            NumeroPuertas = numeroPuertas;
            Ocupado = ocupado;
        }
    }
}
