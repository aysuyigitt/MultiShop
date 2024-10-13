namespace MultiShop.Catalog.Services.StatistikServices
{
    public interface IStatisticService
    {
        Task<long> GetCategoryCount();

        Task<long> GetProductCount();

        Task<long> GetBrandCount();

        Task<decimal> GetProductAvgPrice();

        Task<string> GetMaxPriceproductName();

        Task<string> GetMinPriceproductName();

    }
}
