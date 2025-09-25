
using CardacciPacial.UI.Dominio;

namespace CardacciPacial.UI.Clases
{
    public abstract class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public abstract decimal AbonarCuota(Cuota cuota);
    }
}
