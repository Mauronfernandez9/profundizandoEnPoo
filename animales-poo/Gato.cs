using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_poo
{
    internal class Gato : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "Miau miau...";
        }
        public override string ToString()
        {
            return "Soy un gato...";
        }
    }
}
