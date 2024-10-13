using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.CORS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CORS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Features.CORS.Handlers.AddressHandlers;
using MultiShop.Order.Application.Features.CORS.Handlers.OrderDetailHandlers;
using MultiShop.Order.Application.Features.CORS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CORS.Queries.OrderDetailQueries;

namespace MultiShop.Order.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly GetOrderDetailQueryHandler _getOrderDetailQueryHandler;
        private readonly GetOrderDetailByIdQueryHandler _getOrderDetailIdQueryByIdHandler;
        private readonly CreateOrderDetailCommandHandler _createOrderDetailCommandHandler;
        private readonly UpdateOrderDetailQueryCommandHandler _updateOrderDetailQueryHandler;
        private readonly RemoveOrderDetailQueryCommandHandler _removeOrderDetailQueryHandler;

        public OrderDetailsController(GetOrderDetailQueryHandler getOrderDetailQueryhandler, GetOrderDetailByIdQueryHandler getOrderDetailIdQueryhandler, CreateOrderDetailCommandHandler createOrderDetailCommandHandler, UpdateOrderDetailQueryCommandHandler
            updateOrderDetailQueryHandler, RemoveOrderDetailQueryCommandHandler removeOrderDetailQueryHandler)
        {
            _getOrderDetailQueryHandler = getOrderDetailQueryhandler;
            _getOrderDetailIdQueryByIdHandler = getOrderDetailIdQueryhandler;
            _createOrderDetailCommandHandler = createOrderDetailCommandHandler;
            _updateOrderDetailQueryHandler = updateOrderDetailQueryHandler;
            _removeOrderDetailQueryHandler = removeOrderDetailQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            var values = await _getOrderDetailQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailtById(int id)
        {
            var values = await _getOrderDetailIdQueryByIdHandler.Handle(new GetOrderDetailByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand createOrderDetailCommand)
        {
            await _createOrderDetailCommandHandler.Handle(createOrderDetailCommand);
            return Ok("Şipariş detayı başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveOrderDetail(int id)
        {
            await _removeOrderDetailQueryHandler.Handle(new RemoveOrderDetailCommand(id));
            return Ok("Sipariş detayı  başarıyla silindi");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
        {
            await _updateOrderDetailQueryHandler.Handle(command);
            return Ok("Sipariş detayı başarıyla güncellendi");
        }

    }
}
