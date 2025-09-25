using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardacciPacial.UI.Dominio;

namespace CardacciPacial.UI.Clases
{
    internal class ClientePrincipiante : Cliente
    {
        public override decimal AbonarCuota(Cuota cuota)
        {
            throw new NotImplementedException();
        }
    }
}
