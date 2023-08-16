using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Ej2 : IEjercicio
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el nombre de la persona: ");
            string? personaNombre = Console.ReadLine();

            Console.Write("Ingrese el nombre de una ciudad: ");
            string? ciudadNombre = Console.ReadLine();

            Console.WriteLine("Hola " + personaNombre + " bienvenido a " +ciudadNombre);
        }
    }
}
