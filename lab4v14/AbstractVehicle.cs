// Абстрактний клас із базовою реалізацією
public abstract class AbstractVehicle : IVehicle
{
    public string Model { get; protected set; }
    public double FuelConsumption { get; protected set; }
    public double Distance { get; protected set; }

    // Композиція — об'єкт для обчислень
    protected FuelCalculator fuelCalculator;

    public AbstractVehicle(string model, double fuelConsumption, double distance)
    {
        Model = model;
        FuelConsumption = fuelConsumption;
        Distance = distance;
        fuelCalculator = new FuelCalculator();
    }

    public abstract double CalculateFuelCost();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Витрати пального: {FuelConsumption} л/100 км");
        Console.WriteLine($"Відстань: {Distance} км");
    }
}
