using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Servicios;

namespace Proyecto_Animal.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        [HttpGet]
        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta( Animal a)
        {
            AnimalesServicio.Alta(a);
            return Redirect("Alimentacion");
        }

        public ActionResult Alimentacion()
        {
            var lista = AnimalesServicio.ObtenerTodos();
            return View(lista);
        }

    }
}