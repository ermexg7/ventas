using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CiudadBL
    {
        public List<Ciudad> ListaDeCiudad { get; set; }

        public CiudadBL()
        {
            ListaDeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();

        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Santa Rosa");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");

            ListaDeCiudad.Add(ciudad1);
            ListaDeCiudad.Add(ciudad2);
        }
    }
}
