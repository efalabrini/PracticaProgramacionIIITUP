using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.ej5
{
    internal class coche : IVehiculo
    {
        public int Gasolina { get; set; }

        public coche(int gasolina)
        {
            Gasolina = gasolina;
        }

        public void Conducir()
        {
            if (Gasolina > 0)
            {
                Console.WriteLine("el coche esta conduciendo");
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            Gasolina = Gasolina + cantidad;

            return true;
        }
    }
}
