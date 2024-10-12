using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeViajes
{
    internal class Persona
    {
        public Persona(string nombre, string apellido, string nacionalidad, int diaNac, int mesNac, int anioNac, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            Dni = dni;
            this.fechaNacimiento = new FechaNacimiento(diaNac, mesNac, anioNac);
            

        }
        public string Nombre { get; }
        public string Apellido { get; }
        public string Nacionalidad { get; }
        public string Dni { get; }

        private FechaNacimiento fechaNacimiento;

        public Direccion direccion { get; set; }

        public override string ToString()
        {
            return $"Nombre:{Nombre}\nApellido:{Apellido}\nNacionalidad:{Nacionalidad}\nDni:{Dni}\nFecha de nacimiento:{FechaNacimiento}\nDatos de contacto\n{direccion.ToString()}";
        }




        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento.ToString();
            }
        }
        public int Edad
        {
            get
            {
                return fechaNacimiento.Edad;
            }
        }



    }
}
