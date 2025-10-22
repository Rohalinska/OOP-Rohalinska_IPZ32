// Клас Truck (вантажівка) – реалізація AbstractVehicle
public class Truck : AbstractVehicle
{
    public double LoadWeight { get; set; } // тоннаж

    public Truck(string model, double fuelConsumption, double distance, double loadWeight)
        : base(model, fuelConsumption, distance)
    {
        LoadWeight = loadWeight;
    }

    // Витрати зростають при завантаженні
    public override double CalculateFuelCost()
    {
        double adjustedConsumption = FuelConsumption + (LoadWeight * 0.5);
        return fuelCalculator.Calculate(adjustedConsumption, Distance);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Вантаж: {LoadWeight} т");
        Console.WriteLine($"Загальні витрати пального: {CalculateFuelCost():F2} л");
        Console.WriteLine();
    }
}
