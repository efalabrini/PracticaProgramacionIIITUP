using Practica2.Ej4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Ej5
    {
        public void Ejecutar()
        {
            Console.WriteLine("Cuanto combustible tiene tu auto?");
            int combInicial = int.Parse(Console.ReadLine());
            Coche Autito = new(combInicial);
            Console.WriteLine(Autito.CantCombustible);
            Autito.Conducir();

            Console.WriteLine("Cuanto combustible desea cargar?");
            int combustible = int.Parse(Console.ReadLine());
            Console.WriteLine(Autito.CargarCombustible(combustible));
            Console.WriteLine($"Cantidad de combustible: {Autito.CantCombustible}");


        }
}
}
