using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class AsistenciaDocente
    {
        public AsistenciaDocente(Docente docente, DateTime fecha, DateTime horarioEntrada, DateTime horarioSalida)
        {
            Docente = docente;
            Fecha = fecha;
            HorarioEntrada = horarioEntrada;
            HorarioSalida = horarioSalida;
        }

        public Docente Docente { get; }
        public DateTime Fecha { get; }
        public DateTime HorarioEntrada { get; }
        public DateTime HorarioSalida { get; }
        
        public string MostrarHorarioEntrada() 
        {
            return $"{HorarioEntrada.ToString("HH:mm")}";
        }

        public string MostrarHorarioSalida()
        {
            return $"{HorarioSalida.ToString("HH:mm")}";
        }

        public override string ToString()
        {
            return $"ASISTENCIA DEL DÍA {Fecha.ToString("dd-MM-yyyy")}\nNombre de la docente:{Docente.Nombre} {Docente.Apellido}\nHorario de entrada:{MostrarHorarioEntrada()}\nHorario de salida: {MostrarHorarioSalida()}\n-------------------------------------";
        }


    }
}
