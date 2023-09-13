using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Coche : IVehiculo
    {
        private int combustible;

        public Coche(int combustibleInicial)
        {
            combustible = combustibleInicial;
        }
        public void Conducir()
        {
            if (combustible > 0)
            {
                Console.WriteLine("El coche está conduciendo.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para conducir");
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("La cantidad de combustible a cargar no puede ser negativa.");
                return false;
            }

            combustible += cantidad;
            Console.WriteLine($"Se han cargado {cantidad} unidades de combustible. Combustible total: {combustible}");
            return true;

        }


    }
}
