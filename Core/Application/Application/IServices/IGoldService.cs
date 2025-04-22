namespace Application.IServices
{
    public interface IGoldService
    {
        double CalculateGold24(double ouncePrice, double dollarPrice);
        double CalculateGold18(double gold24);
    }

}
