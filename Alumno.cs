using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }

        public Alumno()
        {

        }
        public Alumno(string Nombre, string Matricula)
        {
            this.Nombre = Nombre;
            this.Matricula = Matricula;
        }
    }
}
