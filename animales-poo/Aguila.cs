using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_poo
{
    internal class Aguila : AnimalSalvaje, PuedeVolar
    {
        public string Volar()
        {
            return "Volando como un aguila";
        }
        public override string ToString()
        {
            return "Soy un aguila...";
        }
    }
}
