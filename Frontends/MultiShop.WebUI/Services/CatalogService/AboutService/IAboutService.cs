﻿using MultiShop.DtoLayer.CatalogDtos.AboutDtos;

namespace MultiShop.WebUI.Services.CatalogService.AboutService
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAboutAsync();

        Task CreateAboutAsync(CreateAboutDto createAboutDto);

        Task UpdateAboutAsync(UpdateAboutDto updateAboutDto);

        Task DeleteAboutAsync(string id);

        Task<UpdateAboutDto> GetByIdAboutAsync(string id);
    }
}
