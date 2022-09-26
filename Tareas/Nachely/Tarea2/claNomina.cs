using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely.Tarea2
{
    class claNomina
    {
        private double sueldoBase;
        public double Sueldo
        {
            get
            {
                return sueldoBase;
            }
            set
            {
                sueldoBase = value;
            }
        }
        public claNomina(double sueldo)
        {
            sueldoBase = sueldo;
            valorAFP = sueldoBase * (2.87 / 100);
            valorARS = sueldoBase * (3.04 / 100);
            setValorIRS();
            totalDescuentos = valorAFP + valorARS + valorIRS;
            sueldoNeto = sueldoBase - totalDescuentos;
        }

        private double valorAFP;
        public double ValorAFP
        {
            set
            {
                valorAFP = sueldoBase * (2.87 / 100);
            }
            get
            {
                return valorAFP;
            }
        }
        private double valorARS;

        public double ValorARS
        {
            set
            {
                valorARS = sueldoBase * (3.04 / 100);
            }
            get
            {
                return valorARS;
            }
        }
        private double valorIRS;

        public double ValorISR
        {
            set
            {
                valorIRS = value;

            }
            get
            {
                return valorIRS;
            }

        }

        public double setValorIRS()
        {
            double sueldoAnual = sueldoBase * 12;
            double isrAnual = 0;

            if (sueldoAnual < 416220.02)
            {
                valorIRS = 0;
            }
            else
            {
                if (sueldoAnual >= 416220.02 && sueldoAnual < 624329.01)
                {
                    isrAnual = ((624329.00 - sueldoAnual) * 15 / 100);

                }
                else
                {
                    if (sueldoAnual >= 624329.01 && sueldoAnual < 867123.01)
                    {
                        isrAnual = ((624329.00 - 416220.01) * 15 / 100) + ((sueldoAnual - 624329.01) * 20 / 100);
                    }
                    else
                    {
                        if (sueldoAnual >= 867123.01)
                        {
                            isrAnual = ((sueldoAnual - 867123.01) * 25 / 100);
                        }
                    }
                }
                valorIRS = isrAnual / 12;
            }
            return valorIRS;
        }
        private double totalDescuentos;
        public double TotalDescuentos
        {
            set
            {
                totalDescuentos = valorAFP + valorARS + valorIRS;
            }
            get
            {
                return totalDescuentos;
            }
        }
        private double sueldoNeto;
        public double SueldoNeto
        {
            set
            {
                sueldoNeto = sueldoBase - (valorIRS + valorARS + valorAFP);
            }
            get
            {
                return sueldoNeto;
            }
        }
    }
}
