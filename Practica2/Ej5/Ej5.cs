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
            Car car1 = new Car(0);
            car1.Drive();
            Console.Write("Ingrese la cantidad de combustible a cargar: ");
            int fuel = int.Parse(Console.ReadLine());
            car1.LoadFuel(fuel);
            car1.Drive();
        }
    }
}
