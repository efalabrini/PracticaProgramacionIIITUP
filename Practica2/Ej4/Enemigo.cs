using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej4
{
    public class Enemigo : IMoverse
    {
        public int Vida { get; set; }

        public int Nivel { get; set; }

        public void MoverseEjeX()
        {
            Console.WriteLine("Enemigo se movió en el eje X");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("Enemigo se movió en el eje Y");
        }
    }
}
