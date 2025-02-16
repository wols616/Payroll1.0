using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Contrato
    {
        public int IdContrato { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; } // Nullable para contratos indefinidos
        public int IdPuesto { get; set; }

        // Relación con Empleado y Puesto
        public Empleado Empleado { get; set; }
        public Puesto Puesto { get; set; }
    }
}
