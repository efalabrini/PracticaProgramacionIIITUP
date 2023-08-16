using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ej4 : IEjercicio
    {
        public void Ejecutar()
        {
            int num1,num2;

            Console.WriteLine("Ingrese un número: ");
            int.TryParse(Console.ReadLine(),out num1);


            Console.WriteLine("Ingrese otro número: ");
            int.TryParse(Console.ReadLine() ,out num2);

            int mayor;

            if (num1 == num2)
            {
                Console.WriteLine("Los número son iguales");
            }
            else
            {

                if (num1 > num2)
                {
                    mayor = num1;

                }
                else
                {
                    mayor = num2;
                };

                Console.WriteLine($"{mayor} es el mayor");
            }

        }
    }
}
