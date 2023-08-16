using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Ej5 : IEjercicio
    {
        public void Ejecutar()
        {
            //Ingreso del valor
            Console.Write("Ingrese un día de la semana: ");
            string? diaIngresado = Console.ReadLine();


            //validacion
            if (diaIngresado == null)
            {
                Console.WriteLine("Adios !");
                return;
            }

            List<string> diasDeLaSemana = new List<string>();
            diasDeLaSemana.Add("lunes");
            diasDeLaSemana.Add("martes");
            diasDeLaSemana.Add("miercoles");
            diasDeLaSemana.Add("jueves");
            diasDeLaSemana.Add("viernes");
            diasDeLaSemana.Add("sabado");
            diasDeLaSemana.Add("domingo");

            ////string diaIngresadoNormalizado = diaIngresado.Trim().ToLower();
            ////diaIngresadoNormalizado = diaIngresadoNormalizado.Replace("á", "a");
            ////diaIngresadoNormalizado = diaIngresadoNormalizado.Replace("é", "e");
            ////diaIngresadoNormalizado = diaIngresadoNormalizado.Replace("í", "i");
            ////diaIngresadoNormalizado = diaIngresadoNormalizado.Replace("ó", "o");
            ////diaIngresadoNormalizado = diaIngresadoNormalizado.Replace("ú", "u");
            ////int index = diasDeLaSemana.IndexOf(diaIngresadoNormalizado);

            string diaIngresadoNormalizado = diaIngresado.Trim();
            int index = -1;
            for (int i = 0; i < diasDeLaSemana.Count; i++)
            {
                if (diasDeLaSemana[i].Equals(diaIngresadoNormalizado, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("El día ingresado no es válido");
            }
            else
            {
                if (index > 4)
                {
                    Console.WriteLine("Es fin de semana !");
                }
                else
                {
                    Console.WriteLine("Es día de semana.");
                }
            }


        }
    }
}
