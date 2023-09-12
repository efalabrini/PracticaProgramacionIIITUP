
using Ej5;

Coche coche = new Coche(0);
coche.Conducir();

Console.WriteLine("Ingrese la cantidad de gasolina a cargar");
int cantCombustible = int.Parse(Console.ReadLine());

coche.CargarCombustible(cantCombustible);
coche.Conducir();
