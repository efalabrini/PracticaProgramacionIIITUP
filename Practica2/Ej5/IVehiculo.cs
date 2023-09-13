using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    interface IVehiculo
    {
        protected void Conducir(); //debbo dejar los protected o no es necesario?

        protected bool CargarCombustible(int cant_combustible);
    }
}
