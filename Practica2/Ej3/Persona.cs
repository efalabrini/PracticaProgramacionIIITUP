using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej3
{
    public class Persona
    {

        protected int _edad;
        public void Saludar()
        {
            Console.WriteLine("Hola !");
        }

        public void SetEdad(int edad)
        {
            _edad = edad;
        }
    }
}
