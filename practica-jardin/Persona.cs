using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class Persona
    {
        //public Persona(string nombre,string apellido,string dni,string domicilio,DateTime fechaNac,string nacionalidad)
        //{
        //    Nombre = nombre;
        //    Apellido = apellido;
        //    Dni = dni;
        //    Domicilio = domicilio;
        //    FechaNac = fechaNac;
        //    Nacionalidad = nacionalidad;
        //}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNac { get; set; }
        public string Nacionalidad { get; set; }

        public DateTime fechaActual = DateTime.Now;


        
    
        public int Edad
        {
            get
            {
                int edad = (fechaActual.Year - FechaNac.Year);

                if (FechaNac.Month < fechaActual.Month)
                    return edad;
                else if (FechaNac.Month == fechaActual.Month)
                {
                    if (FechaNac.Day <= fechaActual.Day)
                        return edad;
                    else
                        return edad - 1;
                }
                return edad - 1;

            }
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nApellido:{Apellido}\nDni:{Dni}\nFecha de nacimiento:{FechaNac.ToString("dd-MM-yyyy")}\nEdad:{Edad}\nDomicilio:{Domicilio}";
        }

    }
}
