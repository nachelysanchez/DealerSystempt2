using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerSystempt2.Guias.Nachely.Clase1
{
    class Empleados
    {
        string DUI;
        string nombres;
        string apellidos;
        string cargo;
        float sueldo;
        string fecha_ingreso;
        string departamento;

        public string ObtenerFechaIngreso()
        {
            return fecha_ingreso;
        }

        public string ObtenerDUI()
        {
            return DUI;
        }

        public string ObtenerCargo()
        {
            return cargo;
        }

        public float ObtenerSueldo()
        {
            return sueldo;
        }

        public string ObtenerDepartamento()
        {
            return departamento;
        }

        public string ObtenerNombre()
        {
            return nombres;
        }

        public string ObtenerApellido()
        {
            return apellidos;
        }

        public void ModificarNombre(string nombre)
        {
            nombres = nombre;
        }

        public void ModificarApellido(string apellido)
        {
            apellidos = apellido;
        }

        public void ModificarDUI(string numdui)
        {
            DUI = numdui;
        }

        public void ModificarCargo(string cargo)
        {
            cargo = cargo;
        }

        public void ModificarSueldo(float sueldo)
        {
            sueldo = sueldo;
        }

        public void ModificarDepartamento(string dep)
        {
            departamento = dep;
        }

        public void ModificarFecha(string ingreso)
        {
            fecha_ingreso = ingreso;
        }

        public override string ToString()
        {
            return $"\t\tEmpleado\n" +
                $"1. DUI : {DUI}\n" +
                $"2. Nombres : {nombres}\n" +
                $"3. Cargo : {cargo}\n" +
                $"4. Sueldo : {sueldo}\n" +
                $"5. Fecha : {fecha_ingreso}\n" +
                $"6. Departamento : {departamento}";
        }
    }
}
