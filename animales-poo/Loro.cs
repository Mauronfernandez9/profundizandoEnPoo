using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_poo
{
    internal class Loro : AnimalDomestico, PuedeVolar
    {
        public string Volar()
        {
            return "Volando como un loro...";
        }
        public override string ToString()
        {
            return "Soy un loro...";
        }
    }
}
