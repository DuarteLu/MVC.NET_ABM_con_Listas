using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Compra
    {
        public string Producto { get; set; }
        public double PrecioUnitario { get; set; }
        public double Incentivo { get; set; }
        public int Cantidad { get; set; }
        public int Descuento { get; set; }

        public virtual double CalcularImporteTotal()
        {
            return 0;
        }
    }
}