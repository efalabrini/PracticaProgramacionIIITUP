using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Car : IVehicle
    {
        public int fuelcar;
        public Car(int fuelcar) 
        {
            this.fuelcar = fuelcar;
        }

        public void Drive()
        {
            if (fuelcar > 0)
            {
                Console.WriteLine("El coche esta siendo conducido!");
            }
            else
            {
                Console.WriteLine("El coche no tiene gasolina");
            }
        }

        public bool LoadFuel(int fuel)
        {
            fuelcar += fuel; 
            return true;
        }
    }
}
