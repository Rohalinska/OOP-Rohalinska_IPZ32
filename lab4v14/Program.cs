// Демонстраційна програма
class Program
{
    static void Main(string[] args)
    {
        IVehicle truck = new Truck("Volvo FH", 25, 350, 10);
        IVehicle bus = new Bus("Mercedes Sprinter", 12, 200, 18);

        truck.DisplayInfo();
        bus.DisplayInfo();

        Console.ReadKey();
    }
}
