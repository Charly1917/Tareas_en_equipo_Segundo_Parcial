using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }

        public Cancion()
        {
        }

        public Cancion(string Nombre, string Genero)
        {
            this.Nombre = Nombre;
            this.Genero= Genero;
        }
    }
}
