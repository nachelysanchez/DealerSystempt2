using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Tareas.Nachely
{
    public class claUAPA
    {
        int id;
        string nombre;
        string telefono;
        string asignatura;

        public claUAPA()
        {
            id = 0;
            nombre = "";
            telefono = "";
            asignatura = "";
        }
        public claUAPA(int id, string nombre, string tel, string asig)
        {
            id = id;
            nombre = nombre;
            telefono = tel;
            asignatura = asig;
        }

        public override string ToString()
        {
            return $"Facilitador de UAPA\n\n" +
                $"1. Id: {id}\n" +
                $"2. Nombres: {nombre}\n" +
                $"3. Telefono: {telefono}\n" +
                $"4. Asignatura: {asignatura}";
        }
    }
}
