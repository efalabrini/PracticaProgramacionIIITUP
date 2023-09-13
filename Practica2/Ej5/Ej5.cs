using System;
namespace Practica2.Ej5
{
	public class Ej5
	{
		public void Ejecutar()
		{
            Coche ferrari = new Coche(0);

            Console.Write("Ingrese la cantidad de litros de combustible que desea cargar: ");
            int cantidadDeseadaDeCombustible = Convert.ToInt32(Console.ReadLine());

            bool cargaDeCombustible = ferrari.CargarCombustible(cantidadDeseadaDeCombustible);

            ferrari.Conducir();
        }
	}
}

