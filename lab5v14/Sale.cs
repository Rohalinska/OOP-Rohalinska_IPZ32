namespace lab5v14.Models
{
    public class Sale
    {
        public string Brand { get; }
        public double Liters { get; }
        public double PricePerLiter { get; }

        public double Total => Liters * PricePerLiter;

        public Sale(string brand, double liters, double pricePerLiter)
        {
            if (liters <= 0 || pricePerLiter <= 0)
                throw new InvalidSaleException("Обсяг або ціна не можуть бути від’ємними або нульовими.");

            Brand = brand;
            Liters = liters;
            PricePerLiter = pricePerLiter;
        }

        public override string ToString() =>
            $"{Brand}: {Liters} л × {PricePerLiter} грн = {Total:F2} грн";
    }
}
