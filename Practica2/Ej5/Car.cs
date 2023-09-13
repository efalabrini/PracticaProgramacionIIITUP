using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Car : IVehicle
    {
        protected int _fuelCar;
        public Car(int fuelCar) 
        {
            this._fuelCar = fuelCar;
        }

        public void Drive()
        {
            if (_fuelCar > 0)
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
            _fuelCar += fuel; 
            return true;
        }
    }
}
