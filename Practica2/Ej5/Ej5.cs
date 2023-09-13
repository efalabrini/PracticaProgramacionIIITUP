using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{

    /*
     Crea un programa en C# que implemente una interfaz IVehiculo con dos métodos, uno para Conducir de tipo void 
    y otro para CargarCombustible de tipo bool que tenga un parámetro de tipo entero 
    con la cantidad de combustible a cargar. 
    Después cree una clase Coche con un constructor que reciba un parámetro con la cantidad de gasolina inicial del coche 
    y implemente los métodos de Conducir y CargarCombustible.

    El método Conducir imprimirá en pantalla que el coche está Conduciendo, 
    si la gasolina es mayor a 0. El método CargarCombustible aumentará la gasolina del coche y retornará verdadero.

    Para realizar las pruebas cree un objeto de tipo Coche con 0 de gasolina en el Main del programa y solicite 
    al usuario una cantidad de combustible para cargar, por último ejecute el método Conducir del coche.

     */

    public class Ej5
    {
        public void Ejecutar()
        {
            Console.WriteLine("Bienvenido al programa de Coche");

            // Crear un objeto de tipo Coche con 0 de gasolina
            Coche miCoche = new Coche(0);

            // Solicitar al usuario la cantidad de combustible a cargar
            Console.Write("Ingrese la cantidad de combustible a cargar: ");
            if (int.TryParse(Console.ReadLine(), out int cantidad))
            {
                // Llamar al método CargarCombustible
                bool cargado = miCoche.CargarCombustible(cantidad);

                if (cargado)
                {
                    // Llamar al método Conducir
                    miCoche.Conducir();
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
            }
        }
    }
}
