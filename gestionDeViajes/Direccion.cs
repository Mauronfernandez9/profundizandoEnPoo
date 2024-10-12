using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeViajes
{
    internal class Direccion
    {
       public Direccion(string pais, string provincia, string ciudad, string localidad, string barrio, string calle, int numeroCalle)
        {
            Pais = pais;
            Provincia = provincia;
            Ciudad = ciudad;
            Localidad = localidad;
            Barrio = barrio;
            Calle = calle;
            NumeroCalle = numeroCalle;



        }

        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }

        public override string ToString()
        {
            return $"Pais:{Pais}\nProvincia:{Provincia}\nLocalidad:{Localidad}\nCiudad:{Ciudad}\nBarrio:{Barrio}\nCalle:{Calle} {NumeroCalle}";
        }


    }
}
