using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CuentaCorriente { get; set; }

        public Empleado(int idEmpleado, string dui, string nombre, string apellidos, string telefono, string direccion, string cuentaCorriente)
        {
            IdEmpleado = idEmpleado;
            Dui = dui;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            CuentaCorriente = cuentaCorriente;
        }
        public Empleado() { }
        public Empleado(string dui, string nombre, string apellidos, string telefono, string direccion, string cuentaCorriente)
        {
            Dui = dui;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            CuentaCorriente = cuentaCorriente;
        }
    }
}
