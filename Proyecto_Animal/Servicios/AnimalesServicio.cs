using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Servicios
{
    public class AnimalesServicio
    {
        public static List<Animal> Lista
        {
            get
            {
                if (HttpContext.Current.Session["Lista"] == null)
                    HttpContext.Current.Session["Lista"] = new List<Animal>();
                return (List<Animal>)HttpContext.Current.Session["Lista"];

            }
        }

        public static List<Animal> ObtenerTodos()
        {
            return Lista;
        }

        public static void Alta(Animal a)
        {
            Animal a2;
            if(a.Peso <=10)
            {
                a2 = new Pequeño();
            }
            else if( a.Peso >10 && a.Peso <=250)
            {
                a2 = new Mediano();

            }
            else
            {
                a2 = new Grande();
            }

            a2.Especie = a.Especie;
            a2.Peso = a.Peso;
            Lista.Add(a2);

        }
    }
}