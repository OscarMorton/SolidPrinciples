using PrincipiosSolid.SingleResponsibility.Correcto;

namespace PrincipiosSolid.LiskovSubstitution.Correcto {

    internal class Renault : Coche {

        public override int numAsientos() {
            return 3;
        }

        public override int precioMedioCoche() {
            return 27000;
        }
    }
}