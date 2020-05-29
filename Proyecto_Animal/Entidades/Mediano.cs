
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Mediano :Animal
    {
        public override double CalcularAlimento()
        {
            return Peso * 100;        }
    }
}