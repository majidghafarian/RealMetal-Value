namespace Application.IServices
{
    public interface IPriceCalculator
    {
        PriceResult Calculate(PriceInput input);
    }
}
