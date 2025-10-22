// Клас-компонент (композиція), який виконує обчислення
public class FuelCalculator
{
    public double Calculate(double fuelConsumption, double distance)
    {
        return (fuelConsumption / 100) * distance;
    }
}
