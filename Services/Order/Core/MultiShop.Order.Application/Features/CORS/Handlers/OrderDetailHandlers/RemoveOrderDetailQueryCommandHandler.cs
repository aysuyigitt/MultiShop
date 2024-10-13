﻿using MultiShop.Order.Application.Features.CORS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CORS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailQueryCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public RemoveOrderDetailQueryCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderDetailCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);    
            await _repository.DeleteAsync(value);

        }

    }
}
