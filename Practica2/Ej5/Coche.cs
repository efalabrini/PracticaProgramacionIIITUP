namespace Practica2;

public class Coche : IVehiculo
{    
    public int Gasolina { get; set; }
    public int Litros { get; set; }
    public Coche(int gasolina)
    {
        Gasolina = gasolina;
        Litros = 50;
    }

    public void Conducir(){
        if(Gasolina > 0){
            Console.WriteLine("Conduciendo");
            Gasolina = Gasolina - 5;
        }
        else {
            Console.WriteLine("El coche no tiene gasolina");
        }
        
    }

    public bool CargarCombustible(int combustible){
        this.Gasolina = Gasolina + combustible;
        if(Gasolina >= 0 && Gasolina < Litros){
            Console.WriteLine($"Se cargaron {combustible} litros de gasolina");
            return true;
        }
        else{
            Console.WriteLine("El tanque está lleno");
            return false;
        }
    }
}
