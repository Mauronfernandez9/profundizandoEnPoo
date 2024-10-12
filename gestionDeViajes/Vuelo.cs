using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeViajes
{
    internal class Vuelo
    {
        public Vuelo(int nroVuelo,string origen,string destino,bool vueloDirecto,DateTime fechaViaje,DateTime fechaLlegada)
        {
            NroVuelo = nroVuelo;
            Origen = origen;
            Destino = destino;
            VueloDirecto = vueloDirecto;
            FechaViaje = fechaViaje;
            FechaLlegada = fechaLlegada;
            
        }


        public int NroVuelo { get;}
        public string Origen { get;}
        public string Destino { get;}
        public bool VueloDirecto { get;}
        public DateTime FechaLlegada { get;}
        public DateTime FechaViaje { get;}
        public List<string> escalas = new List<string>();
        public List<Pasajero> listaPasajeros = new List<Pasajero>();


        public void añadirPasajeros(Pasajero pasajero)
        {
            listaPasajeros.Add(pasajero);
            Console.WriteLine("Pasajero agregado!");
            
        }

        public void  ListaPasajeros()
        {
            {Console.WriteLine("Lista de pasajeros");
            foreach(Pasajero pasajero in listaPasajeros)
            {
                Console.WriteLine(pasajero);
            } }
            
        }

        public void MostrarEscalas()
        {
            Console.WriteLine("Escalas:");
            int num = 0;
            foreach(string escala in escalas)
            {
                Console.WriteLine($"{num+1}.{escala}");
                num++;
            }
        }

        public override string ToString()
        {
            return $"Informacion del viaje\nNumero de vuelo:{NroVuelo}\nOrigen:{Origen}\nDestino:{Destino}\nFecha de partida: {FechaViaje}\nFecha de llegada: {FechaLlegada}";
        }

        public void DefinirEscalas()
        {
            if (!VueloDirecto)
            {
                Console.Write("¿Cuantas escalas tiene el vuelo?: ");
                int cantVuelos = int.Parse(Console.ReadLine());
                for (int x = 0; x < cantVuelos; x++)
                {
                    Console.Write($"Cual es el destino{x + 1}: ");
                    escalas.Add(Console.ReadLine());
                }

            }
            else
                Console.WriteLine("Este vuelo es directo... No hay escalas!");


        }

    }
}
