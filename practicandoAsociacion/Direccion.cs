using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicandoAsociacion
{
    internal class Direccion
    {
        public Direccion(string pais, string provincia, string ciudad, string barrio, string domicilio) {
            Pais = pais;
            Provincia = provincia;
            Ciudad = ciudad;
            Barrio = barrio;
            Domicilio = domicilio;
            
        }
        public  string Pais { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public string Domicilio { get; set; }

        public override string ToString()
        {
            return $"Pais:{Pais}\nProvincia:{Provincia}\nCiudad:{Ciudad}\nBarrio:{Barrio}\nDomicilio:{Domicilio}";
        }



    }
}
