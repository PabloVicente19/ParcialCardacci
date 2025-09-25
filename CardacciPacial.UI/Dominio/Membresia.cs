using System;

namespace CardacciPacial.UI.Dominio
{
    public class Membresia
    {
        public string MembresiaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public double Valor { get; set; }
        public byte Descuento { get; private set; }
    }
}
