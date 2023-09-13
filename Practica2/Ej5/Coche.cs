using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {
        private int gasolina;

        public Coche()
        {
            this.gasolina = 0;
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("Conduciendo");
                gasolina--;
            }
            else
            {
                Console.WriteLine("Sin gasolina");
            }
        }
        public bool CargarCombustible(int cantidad)
        {
            if (cantidad > 0)
            {
                gasolina += cantidad;
                Console.WriteLine($"Se cargaron {cantidad} unidades de gasolina.");
                return true;
            }
            else
            {
                Console.WriteLine("La cantidad de gasolina a cargar debe ser mayor que 0.");
                return false;
            }
        }
    }
}
