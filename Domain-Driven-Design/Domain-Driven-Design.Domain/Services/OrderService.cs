using Domain_Driven_Design.Domain.Aggregates;
using Domain_Driven_Design.Domain.Entities;
using Domain_Driven_Design.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder(Guid orderId, string customerName)
        {
            var order = new OrderAggregate(orderId, customerName);
            _orderRepository.Save(order);
        }

        public void AddOrderItem(Guid orderId, Product product, int quantity)
        {
            var order = _orderRepository.GetById(orderId);
            if (order != null)
            {
                order.AddOrderItem(product, quantity);
                _orderRepository.Save(order);
            }
        }
    }

}
