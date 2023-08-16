using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ej3 : IEjercicio
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese su nombre: ");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            string? edad = Console.ReadLine();

            Console.WriteLine($"Te llamas {nombre} y tienen {edad} años");
        }
    }
}
