using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace holamundo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            var productosBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;


            var categoriasBl = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBl.ListadeCategorias;

        }
    }
}
