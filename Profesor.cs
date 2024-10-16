using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }

        public Profesor() { 
        }

        public Profesor(string Nombre, string Materia)
        {
            this.Nombre = Nombre;
            this.Materia = Materia;
        }
    }
}
