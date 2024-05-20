using Domain_Driven_Design.Application.Commands;
using Domain_Driven_Design.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.Handlers
{
    public class AddOrderItemCommandHandler
    {
        private readonly IOrderRepository _orderRepository;

        public AddOrderItemCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Handle(AddOrderItemCommand command)
        {
            var order = _orderRepository.GetById(command.OrderId);
            if (order != null)
            {
                order.AddOrderItem(command.Product, command.Quantity);
                _orderRepository.Save(order);
            }
        }
    }

}
