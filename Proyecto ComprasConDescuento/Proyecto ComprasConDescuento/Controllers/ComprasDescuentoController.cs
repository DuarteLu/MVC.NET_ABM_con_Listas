using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Servicios;


namespace Proyecto_ComprasConDescuento.Controllers
{
    public class ComprasDescuentoController : Controller
    {
        // GET: ComprasDescuento
        public ActionResult CalcularCompras()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcularCompras(Compra compra)
        {
            if (ModelState.IsValid)
            {
                CompraServicio.CalcularCompra(compra);
                return RedirectToAction("Resultado");
            }
            return View();

        }

        public ActionResult Resultado()
        {
            var Lista = CompraServicio.ObtenerTodos();
            return View(Lista);
        }
    }
}