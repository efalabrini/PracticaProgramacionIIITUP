namespace Practica2;

public interface IVehiculo
{
    public void Conducir(){}

    public virtual bool CargarCombustible(int combustible){
        return true;
    }
}
