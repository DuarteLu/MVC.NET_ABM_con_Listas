using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Persona
    {
        public int id { get; set; }
        public string Nombre  { get; set; }
        public string Apellido { get; set; }
        public int IngresoMensual { get; set; }

        public Persona()
        {
            Nombre = null;
            Apellido = null;
            IngresoMensual = 0;
        }

        public Persona(Persona p)
        {
            Nombre = p.Nombre;
            Apellido = p.Apellido;
            IngresoMensual = p.IngresoMensual;
        }
        public virtual double CalcularImpuesto()
        {
            throw new Exception("Una excepción");
        }


}
}