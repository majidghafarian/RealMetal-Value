public class GoldService : IGoldService
{
    private const double OunceToGram = 31.1035;

    public double CalculateGold24(double ouncePrice, double dollarPrice)
    {
        return (ouncePrice / OunceToGram) * dollarPrice;
    }

    public double CalculateGold18(double gold24)
    {
        return gold24 * 0.75;
    }
}