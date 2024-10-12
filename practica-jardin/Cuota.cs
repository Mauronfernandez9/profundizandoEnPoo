using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class Cuota
    {
        public Cuota(float montoCuota, DateTime fechaCuota)
        {
            MontoCuota = montoCuota;
            this.fechaCuota = fechaCuota;
        }

        private DateTime fechaCuota;

        public float MontoCuota { get; }
        public float Montopagado { get; set; }

        private float horaExtra;

        private float montoFinal;
        public float MontoFinal
        {
            get
            {
                montoFinal = MontoCuota + HoraExtra;
                return montoFinal;
            }
        }




  
        private string estadoCuota = "Cuota no abonada";



        public float HoraExtra
        {
            get { return horaExtra; }
        }

        public float CargarHoraExtra(HoraExtra horaExtr)
        {
            horaExtra = horaExtr.PrecioFinalHorasExtras;
            return horaExtra;
        }



        public string EstadoCuota
        {
            get
            {
                return estadoCuota;
            }
        }


        public string DefinirEstadoCuota()
        {
            if (Montopagado == MontoFinal)
            {
                estadoCuota = "Cuota pagada!";
            }
            else
                estadoCuota = "Cuota no abonada!";
            return estadoCuota;
        }

        public string MostrarFechaCuota()
        {
            return fechaCuota.ToString("MMMM-yyyy");
        }

        public override string ToString()
        {
            return $"CUOTA {MostrarFechaCuota()}\nPrecio cuota: ${MontoCuota}\nPrecio de horas extras: ${HoraExtra}\nPrecio final: ${MontoFinal}\nEstado cuota: {EstadoCuota}\n-----------------------------------";
        }



    }
}
