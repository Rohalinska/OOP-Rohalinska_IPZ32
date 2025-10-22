// Інтерфейс транспортного засобу
public interface IVehicle
{
    string Model { get; }
    double FuelConsumption { get; } // л/100 км
    double Distance { get; }        // км

    double CalculateFuelCost();     // метод для обчислення витрат пального
    void DisplayInfo();             // метод для виведення інформації
}
