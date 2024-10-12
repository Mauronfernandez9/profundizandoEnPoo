using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeViajes
{
    internal class Pasajero
    {
        public Pasajero(int nroPasaporte, int cantMaletas, Persona datosPersonales)
        {
            NroPasaporte = nroPasaporte;
            CantMaletas = cantMaletas;
            DatosPersonales = datosPersonales;

        }
        public int NroPasaporte { get; }
        public int CantMaletas { get; }
        public Persona DatosPersonales { get; }

        private int pesoFinalMaletas = 0;

        public bool checkinRealizado = false;

        public List<Vuelo> vuelos = new List<Vuelo>();

        public void agregarVuelos(Vuelo vuelonuevo)
        {
            vuelos.Add(vuelonuevo);
            Console.WriteLine("Vuelo agregado!");
        }

        public void MostrarVuelos()
        {
            int num = 0;
            Console.WriteLine("Vuelos:");
            foreach (Vuelo vuelo in vuelos)
            {
                Console.WriteLine($"{num + 1}:{vuelo}");
            }
        }



        public string CheckinRealizado()
        {


            string respuesta;
            if (checkinRealizado)
                respuesta = "El checking fue realizado!";
            else
                respuesta = "El checking no fue realizado todavia...";
            return respuesta;


        }

        public int PesoFinalMaletas
        {
            get { return pesoFinalMaletas; }
        }

        public override string ToString()
        {
            return $"Datos Personales\n{DatosPersonales}\nNro de pasaporte:{NroPasaporte}\nCantidad de maletas:{CantMaletas}\nPeso total de equipaje: {PesoFinalMaletas}Kg\nEstado de checking:{CheckinRealizado()}";
        }

        public void CalcularPeso()
        {
            for (int x = 0; x < CantMaletas; x++)
            {
                Console.Write($"Ingresa el peso de la maleta {x + 1}: ");
                pesoFinalMaletas += int.Parse(Console.ReadLine());

            }
            Console.WriteLine(PesoFinalMaletas);
        }

        public void RealizarCheckin()
        {
            Console.WriteLine("¿Quieres realizar el checkin?: 1.Si\n2.No ");
            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
                checkinRealizado = true;
            else if (respuesta == 2)
                checkinRealizado = false;
            else
                Console.WriteLine("Respuesta incorrecta... Intenta más tarde");
        }

    }
}
