using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Mascota
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }

        public Mascota()
        {

        }
        public Mascota(string Nombre, string Raza)
        {
            this.Nombre = Nombre;
            this.Raza = Raza;
        }

    }
}
