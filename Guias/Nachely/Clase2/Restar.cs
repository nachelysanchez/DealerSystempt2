using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Guias.Nachely.Clase2
{
    class Restar : Operacion
    {
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
}
