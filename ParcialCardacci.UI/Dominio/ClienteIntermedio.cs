using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCardacci.UI.Dominio
{
    public class ClienteIntermedio : Cliente
    {
        public override float AbonarCuota(Cuota cuota)
        {
            cuota.Precio = cuota.Precio - (cuota.Precio * ObtenerDescuento() / 100);
            return cuota.Precio;
        }
        public override float ObtenerDescuento()
        {
            return 100 * 0.08f;
        }
    }
}
