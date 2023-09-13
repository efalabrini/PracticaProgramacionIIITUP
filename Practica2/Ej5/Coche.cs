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

        // Constructor que recibe la cantidad de gasolina inicial
        public Coche(int cantidadInicial)
        {
            gasolina = cantidadInicial;
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El coche está en movimiento.");
                gasolina--;
            }
            else
            {
                Console.WriteLine("El coche no puede avanzar, necesita cargar combustible.");
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            if (cantidad > 0)
            {
                gasolina += cantidad;
                Console.WriteLine($"Se cargaron {cantidad} litros de gasolina. Total: {gasolina} litros.");
                return true;
            }
            else
            {
                Console.WriteLine("La cantidad de combustible a cargar debe ser mayor que 0.");
                return false;
            }
        }
    }
}
