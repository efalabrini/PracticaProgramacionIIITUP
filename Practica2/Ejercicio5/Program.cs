using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5!");

            Coche Peugout206 = new Coche(65);
            Peugout206.CargarCombustible(35);
            Peugout206.Conducir();
        }
    }
}
