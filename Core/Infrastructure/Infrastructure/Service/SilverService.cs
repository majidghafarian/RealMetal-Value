public class SilverService : ISilverService
{
    private const double OunceToGram = 31.1035;

    public double CalculateSilver999(double ouncePrice, double dollarPrice)
    {
        return (ouncePrice / OunceToGram) * dollarPrice;
    }
}