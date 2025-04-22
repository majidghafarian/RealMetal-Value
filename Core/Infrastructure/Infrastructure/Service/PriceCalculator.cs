namespace Infrastructure.Service
{
    public class PriceCalculator : IPriceCalculator
    {
        public PriceResult Calculate(PriceInput input)
        {
            double goldPerGram24 = (input.GoldOuncePrice / input.OunceToGram) * input.DollarPrice;
            double goldPerGram18 = goldPerGram24 * 0.75;
            double silverPerGram = (input.SilverOuncePrice / input.OunceToGram) * input.DollarPrice;
            double coinPrice = (goldPerGram24 * input.CoinGoldWeight) + input.CoinMintFee;

            return new PriceResult
            {
                Gold24 = Math.Round(goldPerGram24),
                Gold18 = Math.Round(goldPerGram18),
                CoinEmami = Math.Round(coinPrice),
                Silver999 = Math.Round(silverPerGram)
            };
        }
    }
}
