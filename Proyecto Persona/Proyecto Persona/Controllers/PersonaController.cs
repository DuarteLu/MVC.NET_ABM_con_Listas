using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Servicios;

namespace Proyecto_Persona.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Lista()
        {
            var Persona = PersonaServicio.ObtenerTodos();
            return View(Persona);
        }

        [HttpGet]
        public ActionResult Nueva()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevaManual(FormCollection form)
        {
            Persona p = new Persona();
            p.Nombre = form["Nombre"];
            p.Apellido = form["Apellido"];
            p.IngresoMensual =Convert.ToInt32( form["IngresoMensual"]);
            PersonaServicio.Agregar(p);
            return Redirect("Lista");
        }

        [HttpPost]
        public ActionResult NuevaAutomatico(Persona p)
        {
            PersonaServicio.Agregar(p);
            return Redirect("Lista");
        }

        public ActionResult Borrar(int ?id)
        {
            PersonaServicio.Borrar(id);
            return Redirect("/Persona/Lista");
        }

        public ActionResult Detalle(int ?id)
        {
            Persona p = PersonaServicio.ObtenerPorId(id);
            return View(p);
        }

        public ActionResult Editar(Persona p)
        {
            PersonaServicio.Modificar(p);
            return Redirect("Lista");
        }



    }
}