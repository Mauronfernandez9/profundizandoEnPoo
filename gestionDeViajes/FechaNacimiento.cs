using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeViajes
{
    internal class FechaNacimiento
    {
        public FechaNacimiento(int diaNacimiento,int mesNacimiento, int anioNacimiento)
        {
            this.diaNacimiento = diaNacimiento;
            this.mesNacimiento = mesNacimiento;
            this.anioNacimiento = anioNacimiento;
        }

        public DateTime fechaActual = DateTime.Now; 
        public  int diaNacimiento,mesNacimiento,anioNacimiento;
        public override string ToString()
        {
            return $"{diaNacimiento}-{mesNacimiento}-{anioNacimiento}";
        }

        public int Edad
        {
            get
            {
                int edad = 0;

                if (mesNacimiento < fechaActual.Month)
                    edad = fechaActual.Year - anioNacimiento;
                else if (mesNacimiento == fechaActual.Month)
                {
                    if (diaNacimiento <= fechaActual.Day)
                        edad = fechaActual.Year - anioNacimiento;
                    else
                        edad = fechaActual.Year - anioNacimiento - 1;

                }
                else
                    edad = fechaActual.Year - anioNacimiento - 1;
                return edad;


            }
            
        }

    }
}
