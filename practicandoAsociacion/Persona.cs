using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practicandoAsociacion
{
    internal class Persona
    {
        public Persona(string nombre,string apellido,int diaNacimiento,int mesNacimiento,int añoNacimiento) {
            Nombre = nombre;
            Apellido = apellido;
            fechadeNacimiento = new FechadeNacimiento(diaNacimiento,mesNacimiento,añoNacimiento) ;
        }
        public string Nombre { get; }
        public string Apellido { get; }


        public FechadeNacimiento fechadeNacimiento;

        

        public string FechadeNacimiento { 
            get
            {
                return $"La fecha de nacimieto es: {fechadeNacimiento.fechaDeNacimiento}";
            }
         
        }

        public string DecirEdad() {

            return $"Mi edad es {fechadeNacimiento.Edad}";
        
        }


        public Direccion Direccion { get; set; }


    }
}
