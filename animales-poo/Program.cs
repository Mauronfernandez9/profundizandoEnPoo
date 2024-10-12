using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();

            animales.Add(new Aguila());
            animales.Add(new Perro());
            animales.Add(new Gato());
            animales.Add(new Loro());
            animales.Add(new Perro());
            animales.Add(new Perro());
            animales.Add(new Aguila());
            animales.Add(new Gato());

            foreach (Animal animal in animales) {
                Console.WriteLine(animal.Comunicarse());
            }


            List<PuedeVolar> animalesVoladores = new List<PuedeVolar>();

            animalesVoladores.Add(new Aguila());
            animalesVoladores.Add(new Loro());

            foreach(Animal animal in animalesVoladores)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.ReadKey();


        }
    }
}
