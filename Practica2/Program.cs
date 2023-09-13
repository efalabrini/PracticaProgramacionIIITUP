using Practica2;
using Practica2.Ej1;
using Practica2.Ej2;
using Practica2.Ej3;
using Practica2.Ej4;
using Practica2.Ej5;

namespace Practica2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Coche coche = new Coche(0);
            Console.WriteLine("Ingrese la cantidad a cargar: ");
            if (int.TryParse(Console.ReadLine(), out int cantidad))
            {
                if (coche.CargarCombustible(cantidad))
                {
                    coche.Conducir();
                }
            }
            else
            {
                Console.WriteLine("Cantidad ingresada no valida");
            }

        }
    }
}