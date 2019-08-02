using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
   public class ProductosBL
    {
        public List<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Productos>();
            CrearDatosdePrueba();


        }
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptop");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Productos(1, "Laptop DELL", 15000, categoria1);
            var producto2 = new Productos(2, "Laptop Axus", 20000, categoria1);
            var producto3 = new Productos(3, "Mouse Logitech", 150, categoria2);


            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

        }
    }
}
