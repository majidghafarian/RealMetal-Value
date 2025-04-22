public class CoinService : ICoinService
{
    public double CalculateEmamiCoin(double gold24, double weight, double fee)
    {
        return (gold24 * weight) + fee;
    }
}