using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicandoAsociacion
{
    internal class FechadeNacimiento
    {
        public FechadeNacimiento(int diaNac, int mesNac, int anioNac)
        {
            DiaNacimiento = diaNac;
            MesNacimiento = mesNac;
            AnioNacimiento = anioNac;

        }
        public int DiaNacimiento { get; }
        public int MesNacimiento { get; }
        public int AnioNacimiento { get; }

        

        private DateTime fechaActual = DateTime.Now;

        

        public int Edad
        {
            get
            {

                if (MesNacimiento < fechaActual.Month)
                    return fechaActual.Year - AnioNacimiento;
                else if (MesNacimiento == fechaActual.Month)
                {
                    if (DiaNacimiento <= fechaActual.Day)
                        return fechaActual.Year - AnioNacimiento;
                }


                return fechaActual.Year - AnioNacimiento - 1;


            }
        }

        public string fechaDeNacimiento
        {
            get
            {

                return $"{DiaNacimiento}-{MesNacimiento}-{AnioNacimiento}";
            }
        }





    }
}
