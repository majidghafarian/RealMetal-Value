public class PriceCalculator : IMetalPriceCalculator
{
     

    public double CalculateGold24(double goldOuncePrice, double dollarPrice)
    {
        return (goldOuncePrice / Constants.OunceToGram) * dollarPrice;
    }

    public double CalculateGold18(double goldOuncePrice, double dollarPrice)
    {
        double goldPerGram24 = (goldOuncePrice / Constants.OunceToGram) * dollarPrice;
        return goldPerGram24 * 0.75;
    }

    public double CalculateSilver999(double silverOuncePrice, double dollarPrice)
    {
        return (silverOuncePrice / Constants.OunceToGram) * dollarPrice;
    }

    public double CalculateEmamiCoin(double goldOuncePrice, double dollarPrice)
    {
        double goldPerGram24 = (goldOuncePrice / Constants.OunceToGram) * dollarPrice;
        return (goldPerGram24 * Constants.CoinGoldWeight) + Constants.DefaultCoinMintFee;
    }

}

