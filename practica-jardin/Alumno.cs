using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class Alumno : Persona
    {
       public Alumno(string nombrePadre, string apellidoPadre, string nombreMadre, string apellidoMadre, string otroTutor, bool puedeRealizarDeporte, float seguro)
        {
            NombreCompletoPadre = nombrePadre + " "+ apellidoPadre;
            NombreCompletoMadre = nombreMadre + " " + apellidoMadre;
            NombreTutor = otroTutor;
            this.puedeRealizarDeporte = puedeRealizarDeporte;
            Seguro = seguro;
        }
        public string NombreCompletoPadre { get; }
        public string NombreCompletoMadre { get; }
        public string NombreTutor { get; }
        public bool puedeRealizarDeporte;
        public float Seguro { get; }

        private string estadoDelSeguro;

        public string PuedeRealizarDeporte
        {
            get
            {
                if (puedeRealizarDeporte == true)
                {
                    return "El alumno esta apto para realizar deporte!";

                }
                else
                    return "El alumno NO esta apto para realizar deporte!";
            }
        }

        public Sala sala { get; set; }


        public List<Cuota> cuotas = new List<Cuota>();

        public void cargarCuota(Cuota newCuota)
        {
            cuotas.Add(newCuota);
            Console.WriteLine("Cuota cargada con exito!");
        }

        public void MostrarCuotas()
        {
            foreach (Cuota cuota in cuotas)
            {
                Console.WriteLine(cuota.ToString());
            }
        }







        public string EstadoDelSeguro
        {
            get
            {
                if (estadoDelSeguro == "abonado")
                {
                    return "El seguro esta abonado";
                }
                return "El seguro NO esta abonado";

            }

        }

        public string AbonarSeguro()
        {
            estadoDelSeguro = "abonado";
            return "El seguro se pago con exito!...";
        }

        public override string ToString()
        {
            return $"Nombre padre: {NombreCompletoPadre}\nNombre madre: {NombreCompletoMadre}\nPuede realizar deporte:{PuedeRealizarDeporte}\nSeguro:${Seguro}";
        }




    }
}
