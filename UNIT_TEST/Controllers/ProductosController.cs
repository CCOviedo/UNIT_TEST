using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNIT_TEST.Models;

namespace UNIT_TEST.Controllers
{
    public class ProductosController : Controller
    {
        public List<Productos> GetProductos()
        {
            return new List<Productos>
            {
                new Productos
                {
                    IdProducto = 1,
                    Nombre = "Leche",
                    Precio = 22.3,
                    FechaCaducidad = DateTime.Parse(DateTime.Today.ToString())
                },
                new Productos
                {
                    IdProducto = 2,
                    Nombre = "Cacao",
                    Precio = 10,
                    FechaCaducidad = DateTime.Parse(DateTime.Today.ToString())
                },
                new Productos
                {
                    IdProducto = 3,
                    Nombre = "Avellanas",
                    Precio = 5,
                    FechaCaducidad = DateTime.Parse(DateTime.Today.ToString())
                },
                new Productos
                {
                    IdProducto = 4,
                    Nombre = "Azucar",
                    Precio = 8.5,
                    FechaCaducidad = DateTime.Parse(DateTime.Today.ToString())
                }
            };
        }

        public ActionResult Index()
        {
            List<Productos> productos = this.GetProductos();
            return View(productos);
        }

        public ActionResult Vistas()
        {
            ViewData["Nombre"] = "Alcachofas";
            ViewBag.Prueba = "Berenjenas";
            return View();
        }

        public ActionResult Redireccion(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}
