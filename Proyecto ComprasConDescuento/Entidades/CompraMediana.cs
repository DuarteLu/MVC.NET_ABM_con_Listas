using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class CompraMediana:Compra
    {
        public override double CalcularImporteTotal()
        {
            Incentivo = 0;
            var CompraEnBruto = PrecioUnitario * Cantidad;
            if(CompraEnBruto > 10000)
            {
                Descuento = 30;
            }
            else
            {
                Descuento = 20;
            }
            var MontoDescuento = CompraEnBruto / Descuento / 100;
            return CompraEnBruto - MontoDescuento - Incentivo;
        }
    }
}