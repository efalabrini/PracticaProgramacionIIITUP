using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Coche : IVehiculo
    {
        protected int combustible;

        public Coche(int combInicial)
        {
            combustible = combInicial;
        }

        public void Conducir()
        {
            if (combustible > 0)
            {
                Console.WriteLine("Conduciendo");
            }
            else
            {
                Console.WriteLine("Combustible insuficiente");
            }

        }

        public bool CargarCombustible(int cantCombustible)
        {
            combustible += cantCombustible;
            Console.WriteLine($"combustible actual {combustible} litros");
            return true;

        }

    }
}
