using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal interface IVehiculo
    {
        void Conducir();

        bool CargarCombustible(int cantidad);
    }
}
