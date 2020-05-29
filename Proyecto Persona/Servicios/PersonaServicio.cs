using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Servicios
{
    public class PersonaServicio
    {
        static List<Persona> Personas = new List<Persona>();

        public static void Agregar(Persona p)
        {
            if(p.IngresoMensual == 0)
            {
                p = new Desempleado(p);
            }
            else if( p.IngresoMensual >0 && p.IngresoMensual <250000)
            {
                p = new Empleado(p);
            }
            else if(p.IngresoMensual >= 250000)
            {
                p = new Empresario(p);
            }
            else
            {
                throw new Exception("Ingreso mensual Invalido");
            }
            var Id = Personas.Count() + 1;
            p.id = Id;
            Personas.Add(p);
        }

        public static void Borrar(int ?Id)
        {
            Personas.RemoveAll(o => o.id == Id);
        }

        public static List<Persona> ObtenerTodos()
        {
            return Personas;
        }

        public static void Modificar(Persona p)
        {
            Borrar(p.id);
            Agregar(p);
        }

        public static Persona ObtenerPorId(int ?id)
        {
            foreach( var p in Personas)
            {
                if(p.id== id)
                { return p; }
            }
            return null;
        }
    }
}