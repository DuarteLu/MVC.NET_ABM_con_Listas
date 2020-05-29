using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Grande : Animal
    {
        public override double CalcularAlimento()
        {
            return Peso * 50;        }
    }
}