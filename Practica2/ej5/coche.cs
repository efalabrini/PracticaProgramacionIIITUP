using Practica2.ej5;
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

        public Coche(int gasolinaInicial)
        {
            gasolina = gasolinaInicial;
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El coche está conduciendo.");
            }
            else
            {
                Console.WriteLine("El coche no puede conducir, no tiene gasolina.");
            }
        }
        public bool CargarCombustible(int cantidad)
        {
            if (cantidad > 0)
            {
                gasolina += cantidad;
                Console.WriteLine($"Se han cargado {cantidad} litros de gasolina. Gasolina total: {gasolina} litros.");
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