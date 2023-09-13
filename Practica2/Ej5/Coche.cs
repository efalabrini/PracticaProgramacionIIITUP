using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Coche : IVehiculo
    {
        public int Gasolina { get; set; }
        public Coche(int gasolinaInicial)
        {
            Gasolina = gasolinaInicial;
        }
        public void Conducir()
        {
            if (Gasolina > 0)
            {
                Console.WriteLine("El coche está Conduciendo");
            }
        }
        public bool CargarCombustible(int combustible)
        {
            Gasolina += combustible;
            return true;
        }
    }
}
