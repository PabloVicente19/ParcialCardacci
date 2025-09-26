using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCardacci.UI.Dominio
{
    public class Membresia
    {
        public string Codigo { get; private set; }
        public DateTime FechaInicio { get; set; }
        public short ValorDeDescuento { get; set; }

        public Membresia(string codigo, short descuento, DateTime fechaInicio)
        {
            Codigo = codigo;
            ValorDeDescuento = descuento;
            FechaInicio = fechaInicio;
        }
    }
}
