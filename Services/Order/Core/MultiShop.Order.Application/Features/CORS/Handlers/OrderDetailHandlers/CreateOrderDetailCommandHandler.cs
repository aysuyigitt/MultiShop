using MultiShop.Order.Application.Features.CORS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CORS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateOrderDetailCommand createOrderDetailCommand)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                ProductAmount = createOrderDetailCommand.ProductAmount,
                ProductName = createOrderDetailCommand.ProductName,
                OrderingId = createOrderDetailCommand.OrderingId,
                ProductId = createOrderDetailCommand.ProductId,
                ProductPrice = createOrderDetailCommand.ProductPrice,
                ProductTotalPrice = createOrderDetailCommand.ProductTotalPrice,
            });


        }
    }
}
