using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CategoriaBL
    {
        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriaBL()
        {
            ListadeCategorias = new List<Categoria>();
            DatosdePrueba();

        }

        private void DatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptop");
            var categoria2 = new Categoria(2, "Accesorios");

            ListadeCategorias.Add(categoria1);
            ListadeCategorias.Add(categoria2);
        }

    }
}
