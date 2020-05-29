using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Servicios
{
    public class CompraServicio
    {
        public static List<Compra> ListaDeCompras = new List<Compra>();

        public static void CalcularCompra(Compra compra)
        {
            Compra compra2;
            if(compra.Cantidad >=1 && compra.Cantidad <= 4)
            {
                compra2 = new CompraChica();
            }
            else if( compra.Cantidad >=5&& compra.Cantidad <= 10)
            {
                compra2 = new CompraMediana();
            }
            else if(compra.Cantidad>=11)
            {
                compra2 = new CompraGrande();
            }
            else
            {
                throw new Exception("La cantidad ingresada es incorrecta");
            }

            compra2.Cantidad = compra.Cantidad;
            compra2.PrecioUnitario = compra.PrecioUnitario;
            compra2.Producto = compra.Producto;
            compra2.CalcularImporteTotal();
            ListaDeCompras.Add(compra2);
        }

        public static List<Compra> ObtenerTodos()
        {
            if(ListaDeCompras.Count()== 0)
            {
                ListaDeCompras.Add(new CompraChica
                {    Cantidad = 0,
                    Producto = "Prueba",
                    PrecioUnitario = 0

                });
            }
           return ListaDeCompras;
        }
    }
}