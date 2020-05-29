using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Desempleado : Persona
    {
        public Desempleado(){
            }

    public Desempleado(Persona p): base(p)
    {

    }

        public override double CalcularImpuesto()
        {
            return 0;
        }
    }
}