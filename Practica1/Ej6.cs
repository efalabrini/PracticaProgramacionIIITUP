using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ej6 : IEjercicio
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el precio del producto: ");
            
            double.TryParse(Console.ReadLine(), out double precio);

            Console.WriteLine($"Precio ingresado: {precio.ToString()}");

            Console.WriteLine("Forma de pago");
            Console.WriteLine("1 - Efectivo");
            Console.WriteLine("2 - Tarjeta");
            Console.WriteLine("Ingrese la opción de forma de pago: ");

            int.TryParse( Console.ReadLine(), out int optFormaPago);

            switch (optFormaPago)
            {
                case 1:
                    Console.WriteLine("Pago en efectivo");
                    break;
                
                case 2:
                    Console.Write("Ingrese el número de tarjeta: ");
                    string numTarjeta = Console.ReadLine() ?? "";
                    //numTarjeta ??= "";
                    if (numTarjeta.ToString().Length != 16 )
                    {
                        Console.WriteLine($"Número de tarjeta incorrecto. Ingresado: {numTarjeta}");
                    }
                    else
                    {
                        double precioApagar = precio * 1.1;
                        precioApagar = Math.Round(precioApagar, 2);
                        Console.WriteLine($"Debe pagar {precioApagar.ToString()}");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }
    }
}
