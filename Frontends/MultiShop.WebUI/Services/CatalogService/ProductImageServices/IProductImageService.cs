using MultiShop.DtoLayer.CatalogDtos.ProductImageDto;

namespace MultiShop.WebUI.Services.CatalogService.ProductImageServices
{
    public interface IProductImageService
    {

        Task<List<ResultProductImageDto>> GetAllProductImageAsync();

        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);

        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);

        Task DeleteProductImageAsync(string id);

        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);

        Task<GetByIdProductImageDto> GetByProductIdImageAsync(string id);
    }
}
