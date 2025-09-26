using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCardacci.UI.Dominio
{
    public class ClienteAvanzado : Cliente
    {
        public override float AbonarCuota(double valorCuota)
        {
            //cuota.Precio = cuota.Precio - (cuota.Precio * ObtenerDescuento() / 100);
            //return cuota.Precio;
            throw new NotImplementedException();

        }
        public override float ObtenerDescuento()
        {
            //return 100 * 0.03f;
            throw new NotImplementedException();

        }
    }
}
