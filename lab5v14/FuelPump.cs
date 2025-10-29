using System.Collections.Generic;
using System.Linq;

namespace lab5v14.Models
{
    public class FuelPump
    {
        public string PumpId { get; }
        private List<Sale> sales = new();

        public FuelPump(string id)
        {
            PumpId = id;
        }

        public void AddSale(Sale sale) => sales.Add(sale);
        public IReadOnlyList<Sale> GetSales() => sales.AsReadOnly();

        public double TotalIncome() => sales.Sum(s => s.Total);
        public double TotalLiters() => sales.Sum(s => s.Liters);

        public double AveragePricePerLiter() =>
            sales.Any() ? sales.Average(s => s.PricePerLiter) : 0;
    }
}
