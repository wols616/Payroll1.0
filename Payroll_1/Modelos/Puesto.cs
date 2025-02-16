using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_1.Modelos
{
    internal class Puesto
    {
        public int IdPuesto { get; set; }
        public string NombrePuesto { get; set; }
        public int IdCategoria { get; set; }

        // Relación con Categoria
        public Categoria Categoria { get; set; }
    }
}
