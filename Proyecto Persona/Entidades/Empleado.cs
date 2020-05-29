using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Empleado : Persona
    {
        public Empleado()
        {

        }
        public Empleado(Persona p) : base(p)
        {

        }
        public override double CalcularImpuesto()
        {
            return IngresoMensual * 0.1;
        }
    }
}