using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Empresario :Persona
    {
        public Empresario()
        {

        }
        public Empresario(Persona p): base(p)
        {

        }
        public override double CalcularImpuesto()
        {
            return IngresoMensual * 0.3;
        }
    }
}