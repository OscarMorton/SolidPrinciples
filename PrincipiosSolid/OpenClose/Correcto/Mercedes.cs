using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrincipiosSolid.SingleResponsibility.Correcto;

namespace PrincipiosSolid.SingleResponsibility.OpenClose.Correcto {

    internal class Mercedes : Coche {

        public override int precioMedioCoche() {
            return 27000;
        }
    }
}