﻿using MultiShop.DtoLayer.CatalogDtos.SpecialOfferDtos;

namespace MultiShop.WebUI.Services.CatalogService.SpecialOfferServices
{
    public interface ISpecialOfferService
    {

        Task<List<ResultSpecialOfferDto>> GetAllSpecialOffersAsync();

        Task<UpdateSpecialOfferDto> GetByIdSpecialOfferAsync(string id);

        Task CreateSpecialOfferAsync(CreateSpecialOfferDto createSpecialOfferDto);

        Task UpdateSpecialOfferAsync(UpdateSpecialOfferDto updateSpecialOfferDto);

        Task DeleteSpecialOfferAsync(string id);

    }
}
