using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Car : IVehicle
    {
        public int fuelCar;
        public Car(int fuelCar) 
        {
            this.fuelCar = fuelCar;
        }

        public void Drive()
        {
            if (fuelCar > 0)
            {
                Console.WriteLine("El coche esta siendo conducido!");
            }
            else
            {
                Console.WriteLine("El coche no tiene combustible");
            }
        }

        public bool LoadFuel(int fuel)
        {
            fuelCar += fuel; 
            return true;
        }
    }
}
