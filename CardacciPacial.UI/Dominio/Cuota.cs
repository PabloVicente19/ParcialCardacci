using System;
using CardacciPacial.UI.Clases;

namespace CardacciPacial.UI.Dominio
{
    public class Cuota
    {
        public int CuotaId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Precio { get; set; }
        public Cliente Cliente { get; set; }
        public Membresia Membresia { get; set; }
    }
}
