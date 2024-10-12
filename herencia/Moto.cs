using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Moto : Vehiculo
    {
        private int velocidadMax = 180;

        public override string AndarAVelocidadMax()
        {
            return $"Conduciendo a {velocidadMax} KM/H";

        }

        public override string TocarBocina()
        {
            return "riing riiing...";
        }
    }
}
