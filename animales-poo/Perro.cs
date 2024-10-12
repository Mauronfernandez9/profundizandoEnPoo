using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_poo
{
    internal class Perro : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "Guau guau...";
        }
        public override string ToString()
        {
            return "Soy un perro...";
        }
    }
}
