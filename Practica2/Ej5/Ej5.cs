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
            // Crear un objeto de tipo Coche con 0 de gasolina
            Coche miCoche = new Coche(0);

            // Solicitar al usuario la cantidad de combustible para cargar
            Console.Write("Ingrese la cantidad de gasolina a cargar: ");
            if (int.TryParse(Console.ReadLine(), out int cantidadCarga))
            {
                // Llamar al método CargarCombustible
                if (miCoche.Cargar(cantidadCarga))
                {
                    // Ejecutar el método Conducir después de cargar combustible
                    miCoche.Conducir();
                }
            }
            else
            {
                Console.WriteLine("La entrada no es válida. Debe ingresar un número entero.");
            }
        }
    }
}
