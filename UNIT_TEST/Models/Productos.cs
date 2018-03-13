using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIT_TEST.Models
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public DateTime FechaCaducidad { get; set; }
    }
}