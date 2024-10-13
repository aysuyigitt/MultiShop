﻿using MultiShop.DtoLayer.CatalogDtos.ContactDtos;

namespace MultiShop.WebUI.Services.CatalogService.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetAllContactAsync();

        Task CreateContactAsync(CreateContactDto createContactDto);

        Task UpdateContactAsync(UpdateContactDto updateContactDto);

        Task DeleteContactAsync(string id);

        Task<GetByIdContactDto> GetByIdContactAsync(string id);
    }
}
