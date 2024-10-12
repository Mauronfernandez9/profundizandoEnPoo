using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_jardin
{
    internal class Recaudacion
    {
        public Recaudacion(float dineroGastado)
        {
            this.dineroGastado = dineroGastado;
        }
      

        private float montoObtenido;
        private float dineroGastado;
        private float totalRecaudado;
        public float DineroExtra { get; set; }

        public string CargarDinero(Cuota cuota)
        {
            montoObtenido += cuota.Montopagado;
            return $"Dinero cargado... Actualmente el monto es de ${montoObtenido}";
        }



        public float MontoObtenido
        {
            get { return montoObtenido; }
        }
        public float DineroGastado
        {
            get { return dineroGastado; }
        }
        public float TotalRecaudado
        {
            get
            {
                totalRecaudado = montoObtenido - dineroGastado + DineroExtra;
                return totalRecaudado;
            }





        }

        public override string ToString()
        {
            return $"Se ha recaudado ${TotalRecaudado}";
        }
    }
}
