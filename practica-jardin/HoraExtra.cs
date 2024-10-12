using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class HoraExtra
    {
        public List<AsistenciaAlumno> asistencias = new List<AsistenciaAlumno>();

        public float precioPorHora { get; set; }
        public int cantHoraTotales = 0;
        private float precioFinalHorasExtras;
        public float PrecioFinalHorasExtras
        {
            get { return precioFinalHorasExtras; }
        }


        public string cargarlistaDeAsistencias(AsistenciaAlumno asistenciaNueva)
        {
            asistencias.Add(asistenciaNueva);
            return "Asistencia cargada con exito!";
        }
        public int ObtenerCantidadHorasTotales()
        {
            foreach(AsistenciaAlumno asistencia in asistencias)
            {
                int hora = asistencia.HorasTotales;
                if(hora > 4)
                {
                    hora = hora - 4;
                    cantHoraTotales += hora;
                }
                
            }
            return cantHoraTotales;
        }
        public int CantHorasTotales
        {
            get { return cantHoraTotales; }
        }

        public float CalcularPrecioFinalHorasExtras()
        {
            precioFinalHorasExtras = cantHoraTotales * precioPorHora;
            return precioFinalHorasExtras;
        }



    }
}
