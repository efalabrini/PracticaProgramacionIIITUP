﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public interface IVehiculo
    {
        public void Conducir()
        {
        }

        public bool CargarCombustible(int CantidadCombustible)
        {
            return true;
        }
    }
}
