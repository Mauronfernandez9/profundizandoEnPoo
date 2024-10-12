using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipoDeSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer();
            d1.Apellido = "Pepe";
            d1.Nombre = "Roberto";
            d1.Edad = 34;
            d1.Nacionalidad = "Br";
            d1.Especialidad = "Back-end";

            Console.WriteLine($"Desarrollador\nNombre:{d1.Nombre}\nApellido{d1.Apellido}\nEdad:{d1.Edad}\nNac:{d1.Nacionalidad}\nEspecialidad:{d1.Especialidad}");
            Console.ReadKey();
            
        }
    }
}
