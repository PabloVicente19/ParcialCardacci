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
        public string Dni { get; set; }
        public double Cuota { get; set; }
        public Membresia Membresia { get; set; }
        public Cliente()
        {
            ClienteId = ++_clienteId;
        }

        public void AsignarMembresia(Membresia membresia)
        {
            Membresia = membresia;
        }
        public void EliminarMembresia() => Membresia = null;
        
        // Metodos Polimorficos
        public abstract float AbonarCuota(double valorCuota);
        public abstract float ObtenerDescuento();

    }
}
