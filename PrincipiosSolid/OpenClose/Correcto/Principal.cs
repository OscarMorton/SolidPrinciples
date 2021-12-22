using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrincipiosSolid.SingleResponsibility.Correcto;

namespace PrincipiosSolid.SingleResponsibility.OpenClose.Correcto {

    internal class Principal {

        public static void main(String[] args) {
            Coche[] arrayCoches = {
                new Renault(),
                new Audi(),
                new Mercedes()
            };

            imprimirPrecioMedioCoches(arrayCoches);
        }

        private static void imprimirPrecioMedioCoches(Coche[] arrayCoches) {
            foreach (Coche coche in arrayCoches) {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
    }
}