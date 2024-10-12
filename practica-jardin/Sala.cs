using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class Sala
    {
        public Sala(string nombre, Docente docente, Docente aux)
        {
            Nombre = nombre;
            DocenteACargo = docente.Nombre + " " + docente.Apellido;
            Auxiliar = aux.Nombre + " " + aux.Apellido;
        }
        public string Nombre { get; }
        public string DocenteACargo { get; }
        public string Auxiliar { get; }

        public List<Alumno> alumnos = new List<Alumno>();

        public void MostrarAlumnos()
        {

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }
        }

        public void CargarAlumno(Alumno alumnoNuevo)
        {
            alumnos.Add(alumnoNuevo);
            Console.WriteLine("Alumno cargado!...");
        }

        public override string ToString()
        {
            return $"Sala {Nombre}\nDocente:{DocenteACargo}\nAuxiliar:{Auxiliar}\n-----------------------";
        }
    }
}
