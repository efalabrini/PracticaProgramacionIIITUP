using System;
namespace Practica2.Ej5
{
     public class Coche : IVehiculo
        {
            int combustible;

            public Coche(int CantidadInicialCombustible)
            {
                combustible = CantidadInicialCombustible;
            }

            public void Conducir()
            {
                if (combustible > 0)
                {
                    Console.WriteLine("El coche está conduciendo.");
                }
                else
                {
                    Console.WriteLine("El coche no puede conducir porque no tiene gasolina.");
                }
            }

            public bool CargarCombustible(int CantidadCombustibleACargar)
            {
                if (CantidadCombustibleACargar > 0)
                {
                    combustible += CantidadCombustibleACargar;
                    Console.WriteLine($"Cargaste {CantidadCombustibleACargar} litros de combustible.");
                    Console.WriteLine($"Tanque actual: {combustible} litros.");
                    return true;
                }
                else
                {
                    Console.WriteLine("La cantidad de combustible a cargar debe ser mayor a 0.");
                    return false;
                }
            }
        }
}

