using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCardacci.UI.Dominio
{
    public class Cuota
    {
        public int CuotaId { get; set; }
        public DateTime FechaPago { get; set; }
        public float Precio { get; set; }
        public Cliente Cliente { get; set; }
        public Membresia Membresia { get; set; }
    }
}
