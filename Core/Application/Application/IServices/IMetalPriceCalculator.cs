namespace Application.IServices
{
    public interface IMetalPriceCalculator
    {
        double CalculateGold24(double goldOuncePrice, double dollarPrice);
        public double CalculateGold18(double goldOuncePrice, double dollarPrice);
        double CalculateSilver999(double silverOuncePrice, double dollarPrice);
        public double CalculateEmamiCoin(double goldOuncePrice, double dollarPrice);
    }

}
