 

namespace Application.IServices
{
    public interface IMetalPriceService
    {
        Task<double> GetGoldOuncePriceAsync();
        Task<double> GetSilverOuncePriceAsync();
    }

}
