using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaDeVehiculos = new List<Vehiculo>();


            listaDeVehiculos.Add(new Auto());
            listaDeVehiculos.Add(new AutoDeCarreras());
            listaDeVehiculos.Add(new Moto());
            listaDeVehiculos.Add(new Camioneta());

            




            //foreach (Vehiculo item in listaDeVehiculos)
            //{
            //    Console.WriteLine(item.AndarAVelocidadMax());
            //}




            Console.ReadKey();
        }
    }
}
