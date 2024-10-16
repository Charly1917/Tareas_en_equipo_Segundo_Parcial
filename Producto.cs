using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
        }

        public Producto(string Nombre, decimal Precio)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
        }
    }
}
