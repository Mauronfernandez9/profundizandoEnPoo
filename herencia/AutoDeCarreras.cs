using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class AutoDeCarreras : Auto
    {
        private int velocidadMax = 400;

        public override string AndarAVelocidadMax()
        {
            return $"Conduciendo a {velocidadMax}KM/H";
        }
    }
}
