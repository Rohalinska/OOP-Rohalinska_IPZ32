using System;
using System.Linq;
using lab5v14.Models;
using lab5v14.Repositories;

namespace lab5v14
{
    internal class Program
    {
        static void Main()
        {
            var repo = new Repository<Sale>();
            var pump = new FuelPump("PUMP-1");

            try
            {
                repo.Add(new Sale("A-95", 30, 52));
                repo.Add(new Sale("Diesel", 50, 49));
                repo.Add(new Sale("A-95", 20, 51));
                // Помилка
                repo.Add(new Sale("A-92", -10, 48));
            }
            catch (InvalidSaleException ex)
            {
                Console.WriteLine($"❌ Помилка продажу: {ex.Message}");
            }

            foreach (var sale in repo.All())
                pump.AddSale(sale);

            Console.WriteLine("\nПродажі:");
            foreach (var s in pump.GetSales())
                Console.WriteLine($" - {s}");

            Console.WriteLine($"\nЗагальний дохід: {pump.TotalIncome():F2} грн");
            Console.WriteLine($"Продано літрів: {pump.TotalLiters():F2} л");
            Console.WriteLine($"Середня ціна за літр: {pump.AveragePricePerLiter():F2} грн");

            Console.WriteLine("\nДохід по марках:");
            var grouped = pump.GetSales()
                .GroupBy(s => s.Brand)
                .Select(g => new { Brand = g.Key, Income = g.Sum(s => s.Total) });

            foreach (var g in grouped)
                Console.WriteLine($" - {g.Brand}: {g.Income:F2} грн");
        }
    }
}
