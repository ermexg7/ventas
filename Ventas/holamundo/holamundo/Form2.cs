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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var clientesBL = new ClienteBL();
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;


            var ciudadBL = new CiudadBL();
            listaDeCiudadBindingSource.DataSource = ciudadBL.ListaDeCiudad;


        }
    }
}
