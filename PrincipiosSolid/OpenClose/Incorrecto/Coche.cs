using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsibility.OpenClose.Incorrecto {

    internal class Coche {
        private String marca;

        private Coche(String marca) {
            this.marca = marca;
        }

        private String getMarcaCoche() {
            return marca;
        }
    }
}