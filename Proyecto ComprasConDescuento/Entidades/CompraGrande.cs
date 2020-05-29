using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class CompraGrande : Compra
    {
        public override double CalcularImporteTotal()
        {
            Incentivo = 1000;
            Descuento = 50;
            var MontoDescuento = (PrecioUnitario * Cantidad) * Descuento / 100;
            return (PrecioUnitario * Cantidad) - MontoDescuento - Incentivo;
        }
    }
}