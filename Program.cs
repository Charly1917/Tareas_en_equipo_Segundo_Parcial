using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            List<Mascota> mascotas = new List<Mascota>();
            List<Profesor> profesores = new List<Profesor>();
            List<Producto> productos = new List<Producto>();
            List<Cancion> canciones = new List<Cancion>();

            for (int i = 1; i <=2; i++)
            {
                alumnos.Add(new Alumno { Id = i, Nombre = $"Alumno {i}", Matricula ="22109009" });
                mascotas.Add(new Mascota { Id = i, Nombre = $"Mascota {i}", Raza = "Perro" });
            }

            string alumnosJson = JsonConvert.SerializeObject(alumnos);
            string mascotasJson = JsonConvert.SerializeObject(mascotas);

            Console.WriteLine("Alumnos en JSON:");
            Console.WriteLine(alumnosJson);
            Console.WriteLine();
            Console.WriteLine("Mascotas en JSON:");
            Console.WriteLine(mascotasJson);

            Console.ReadKey();
        }
    }


}
   
