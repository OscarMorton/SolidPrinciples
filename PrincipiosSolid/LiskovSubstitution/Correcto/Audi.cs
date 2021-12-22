using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrincipiosSolid.SingleResponsibility.Correcto;

namespace PrincipiosSolid.LiskovSubstitution.Correcto {

    internal class Audi : Coche {

        public override int numAsientos() {
            throw 5;
        }

        public override int precioMedioCoche() {
            return 25000;
        }
    }
}