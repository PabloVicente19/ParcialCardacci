
using CardacciPacial.UI.Dominio;

namespace CardacciPacial.UI.Clases
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
