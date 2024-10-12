using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Auto : Vehiculo
    {
        private int velocidadMax = 240;
        public override string TocarBocina()
        {
            return "PI... PI...";
        }
        public override string AndarAVelocidadMax()
        {
            return $"Conduciendo a  {velocidadMax}KM/H";
        }
    }
}
