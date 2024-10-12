using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class Docente : Persona
    {

        public Docente(string titulo, int anioDeIngresoAlSistema, float sueldo, string cargo)
        {
            Titulo = titulo;
            AnioDeExperiencia = DateTime.Now.Year - anioDeIngresoAlSistema;
            Sueldo = sueldo;
            Cargo = cargo;
        }

        public string Titulo { get; }
        public int AnioDeExperiencia { get; }
        public float Sueldo { get; }
        public string Cargo { get; }

        private List<AsistenciaDocente> asistenciaEnero = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaFebrero = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaMarzo = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaAbril = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaMayo = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaJunio = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaJulio = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaAgosto = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaSeptiembre = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaOctubre = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaNoviembre = new List<AsistenciaDocente>();
        private List<AsistenciaDocente> asistenciaDiciembre = new List<AsistenciaDocente>();


        public void AsistenciaEnero()
        {
            if (asistenciaEnero.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaEnero)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para enero...");

        }

        public void AsistenciaFebrero()
        {
            if (asistenciaFebrero.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaFebrero)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para febrero...");

        }
        public void AsistenciaMarzo()
        {
            if (asistenciaMarzo.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaMarzo)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para marzo...");

        }
        public void AsistenciaAbril()
        {
            if (asistenciaAbril.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaAbril)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para abril...");

        }
        public void AsistenciaMayo ()
        {
            if (asistenciaMayo.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaMayo)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para mayo...");

        }
        public void AsistenciaJunio()
        {
            if (asistenciaJunio.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaJunio)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para junio...");

        }
        public void AsistenciaJulio()
        {
            if (asistenciaJulio.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaJulio)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para julio...");

        }

        public void AsistenciaAgosto()
        {
            if (asistenciaAgosto.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaAgosto)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para agosto...");

        }

        public void AsistenciaSeptiembre()
        {
            if (asistenciaSeptiembre.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaSeptiembre)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para septiembre...");

        }

        public void AsistenciaOctubre()
        {
            if (asistenciaOctubre.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaOctubre)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para octubre...");

        }

        public void AsistenciaNoviembre()
        {
            if (asistenciaNoviembre.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaNoviembre)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para noviembre...");

        }

        public void AsistenciaDiciembre()
        {
            if (asistenciaDiciembre.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in asistenciaDiciembre)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para diciembre...");

        }















        public void MostrarAsistencias(List<AsistenciaDocente> mes)
        {
            if (mes.Count != 0)
            {
                foreach (AsistenciaDocente asistencia in mes)
                {
                    Console.WriteLine(asistencia.ToString());
                }
            }
            else
                Console.WriteLine("No se cargaron asistencia para dicho mes...");
        }

        public void AgregarAsistencia(AsistenciaDocente asistenci)
        {

            Console.WriteLine("Escribe el nro del mes en el cual quieres cargar la asistencia:\n1.Enero\n2.Febrero\n3.Marzo\n4.Abril\n5.Mayo\n6.Junio\n7.Julio\n8.Agosto\n9.Septiembre\n10.Octubre\n11.Noviembre\n12.Diciembre");
            int mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    asistenciaEnero.Add(asistenci);
                    break;
                case 2:
                    asistenciaFebrero.Add(asistenci);
                    break;
                case 3:
                    asistenciaMarzo.Add(asistenci);
                    break;
                case 4:
                    asistenciaAbril.Add(asistenci);
                    break;
                case 5:
                    asistenciaMayo.Add(asistenci);
                    break;
                case 6:
                    asistenciaJunio.Add(asistenci);
                    break;
                case 7:
                    asistenciaJulio.Add(asistenci);
                    break;
                case 8:
                    asistenciaAgosto.Add(asistenci);
                    break;
                case 9:
                    asistenciaSeptiembre.Add(asistenci);
                    break;
                case 10:
                    asistenciaOctubre.Add(asistenci);
                    break;
                case 11:
                    asistenciaNoviembre.Add(asistenci);
                    break;
                case 12:
                    asistenciaDiciembre.Add(asistenci);
                    break;
            }
            Console.WriteLine("Asistencia cargada...");
        }

        public override string ToString()
        {
            return $"Titulo:{Titulo}\nAño de experiencia:{AnioDeExperiencia} años\nSueldo:${Sueldo}\nCargo:{Cargo}";
        }






    }


}
