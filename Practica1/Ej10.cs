using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Ej10 : IEjercicio
    {
        public void Ejecutar()
        {
            //Declaro las listas
            List<int> listaPares = new List<int>();
            List<int> listaDiv3 = new List<int>();

            //Recorro y separo las listas
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    listaPares.Add(i);
                }
                
                if (i % 3 == 0)
                {
                    listaDiv3.Add(i);
                }
                
            }

            //Muestro las listas
            Console.WriteLine("Lista pares");
            foreach (int i in  listaPares) {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Lista div 3");
            foreach (int i in listaDiv3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
