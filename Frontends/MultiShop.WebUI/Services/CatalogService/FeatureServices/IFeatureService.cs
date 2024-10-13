﻿using MultiShop.DtoLayer.CatalogDtos.FeatureDtos;

namespace MultiShop.WebUI.Services.CatalogService.FeatureServices
{
    public interface IFeatureService
    {
        Task<List<ResultFeatureDto>> GetAllFeaturesAsync();

        Task CreateFeatureAsync(CreateFeatureDto createFeatureDto);

        Task UpdateFeatureAsync(UpdateFeatureDto updateFeatureDto);

        Task DeleteFeatureAsync(string id);

        Task<UpdateFeatureDto> GetByIdFeatureAsync(string id);
    }
}
