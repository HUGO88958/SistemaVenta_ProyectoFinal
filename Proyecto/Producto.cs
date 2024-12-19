using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalP2
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Imagen { get; set; } // Ruta imagen producto
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
    }
}
