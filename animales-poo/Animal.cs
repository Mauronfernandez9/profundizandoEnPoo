﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animales_poo
{
    internal class Animal
    {
        public string Color { get; set; }
        public int Edad { get; set; }

        public virtual string Comunicarse()
        {
            return "Ruido... ruido...";
        }
    }
}
