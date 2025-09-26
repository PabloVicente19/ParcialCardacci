using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCardacci.UI.Dominio
{
    public abstract class Cliente
    {
        private static int _clienteId = 0;
        public int ClienteId { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public abstract float AbonarCuota(Cuota cuota);
        public abstract float ObtenerDescuento();
    }
}
