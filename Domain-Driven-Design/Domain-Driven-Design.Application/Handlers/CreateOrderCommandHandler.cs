using Domain_Driven_Design.Application.Commands;
using Domain_Driven_Design.Domain.Aggregates;
using Domain_Driven_Design.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.Handlers
{
    public class CreateOrderCommandHandler
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Handle(CreateOrderCommand command)
        {
            var order = new OrderAggregate(command.OrderId, command.CustomerName);
            _orderRepository.Save(order);
        }
    }

}
