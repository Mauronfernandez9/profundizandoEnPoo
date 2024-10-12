using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Motor { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual string TocarBocina()
        {
            return "ruido de bocina...";
        }

        public virtual string AndarAVelocidadMax()
        {
            return "Conduciendo a velocidad maxima...";
        }



    }
}
