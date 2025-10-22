// Клас Bus (автобус) – реалізація AbstractVehicle
public class Bus : AbstractVehicle
{
    public int Passengers { get; set; }

    public Bus(string model, double fuelConsumption, double distance, int passengers)
        : base(model, fuelConsumption, distance)
    {
        Passengers = passengers;
    }

    // Витрати збільшуються залежно від кількості пасажирів
    public override double CalculateFuelCost()
    {
        double adjustedConsumption = FuelConsumption + (Passengers * 0.1);
        return fuelCalculator.Calculate(adjustedConsumption, Distance);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Кількість пасажирів: {Passengers}");
        Console.WriteLine($"Загальні витрати пального: {CalculateFuelCost():F2} л");
        Console.WriteLine();
    }
}
