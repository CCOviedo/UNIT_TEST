using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNIT_TEST.Controllers;
using System.Web.Mvc;

namespace UNIT_TEST.Tests.Controllers
{
    [TestClass]
    public class ProductosTest
    {
        [TestMethod]
        public void IndexTest()
        {
            ProductosController controller = new ProductosController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void VistasTest()
        {
            ProductosController controller = new ProductosController();

            ViewResult result = controller.Vistas() as ViewResult;
            
            Assert.AreEqual("Alcachofas", result.ViewData["Nombre"]);
            Assert.AreEqual("Berenjenas", result.ViewBag.Prueba);

        }

        [TestMethod]
        public void RedireccionTest()
        {
            ProductosController controller = new ProductosController();

            RedirectToRouteResult result = 
                controller.Redireccion(0) as RedirectToRouteResult;

            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("Home", result.RouteValues["controller"]);
        }
    }
}
