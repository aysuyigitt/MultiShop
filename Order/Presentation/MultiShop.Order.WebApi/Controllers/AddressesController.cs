﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.CORS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CORS.Handlers.AddressHandlers;
using MultiShop.Order.Application.Features.CORS.Queries.AddressQueries;


namespace MultiShop.Order.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly GetAddressQueryHandler _getAddressQueryhandler;
        private readonly GetAddressByIdQueryHandler _getAddressByIdQueryhandler;
        private readonly CreateAddressCommandHandler _createAddressCommandHandler;  
        private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;
        private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;

        public AddressesController(GetAddressQueryHandler getAddressQueryhandler, GetAddressByIdQueryHandler getAddressByIdQueryhandler, CreateAddressCommandHandler createAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler,
            RemoveAddressCommandHandler removeAddressCommandHandler)
        {
            _getAddressQueryhandler = getAddressQueryhandler;
            _getAddressByIdQueryhandler = getAddressByIdQueryhandler;
            _createAddressCommandHandler = createAddressCommandHandler;
            _updateAddressCommandHandler = updateAddressCommandHandler;
            _removeAddressCommandHandler = removeAddressCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult>AddressList()
        {
            var values = await _getAddressQueryhandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>AddressListById(int id)
        {
            var values = await _getAddressByIdQueryhandler.Handle(new GetAddressByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult>CreateAddress(CreateAddressCommand command)
        {
            await _createAddressCommandHandler.Handle(command);
            return Ok("Adres bilgisi başarıyla eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAddressCommand command)
        {
            await _updateAddressCommandHandler.Handle(command);
            return Ok("Adres bilgisi başarıyla güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult>RemoveAddress(int id) { 
            await _removeAddressCommandHandler.Handle(new RemoveAddressCommand(id));
            return Ok("Adres bilgisi başarıyla silindi");

        }
    }
}
