using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Animal
    {
        public String  Especie { get; set; }
        public int Peso { get; set; }

        public virtual double CalcularAlimento()
        {
            return 0;
        }
    }
}