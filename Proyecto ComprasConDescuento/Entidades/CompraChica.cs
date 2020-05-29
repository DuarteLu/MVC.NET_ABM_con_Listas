using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class CompraChica :  Compra
    {
        public override double CalcularImporteTotal()
        {
            Incentivo = 0;
            Descuento = 10;

            var MontoDescuento = (PrecioUnitario * Cantidad) * Descuento / 100;
            return (PrecioUnitario * Cantidad) - MontoDescuento - Incentivo;
        }
    }
}