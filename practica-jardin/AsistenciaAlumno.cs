using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class AsistenciaAlumno
    {
        public AsistenciaAlumno(Alumno alumn, Sala sal, DateTime fecha, DateTime horarioEntrada, DateTime horarioSalida)
        {
            Alumno = alumn;
            Fecha = fecha;
            Sala = sal;
            HorarioEntrada = horarioEntrada;
            HorarioSalida = horarioSalida;
            HorasTotales = HorarioSalida.Hour - HorarioEntrada.Hour;

        }

        public Alumno Alumno { get; }
        public DateTime Fecha { get; }
        public Sala Sala { get; }

        public int CantHorasExtras { get; set; }

        public string nombreDocente;

        public DateTime HorarioEntrada { get; }

        public DateTime HorarioSalida { get; }

        public int HorasTotales { get; }



        public string NombreDocente(Docente docente)
        {
            nombreDocente = docente.Nombre + " " + docente.Apellido;
            return $"La docente {nombreDocente} fue cargada con exito";
        }





       

 

    

        public override string ToString()
        {
            return $"ASISTENCIA DEL DÍA {Fecha.ToString("dd-MM-yyyy")}\nNombre de la docente:{nombreDocente}\nHorario de entrada:{HorarioEntrada.ToString("HH:mm")}\nHorario de salida: {HorarioSalida.ToString("HH:mm")}\n-------------------------------------";
        }
    }
}
