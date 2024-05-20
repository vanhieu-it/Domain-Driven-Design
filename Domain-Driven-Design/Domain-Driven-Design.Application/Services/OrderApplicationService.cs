using Domain_Driven_Design.Application.DTOs;
using Domain_Driven_Design.Application.Interfaces;
using Domain_Driven_Design.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.Services
{
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderApplicationService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderDto GetOrderById(Guid orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order == null) return null;

            return new OrderDto
            {
                OrderId = order.Order.OrderItems,
                CustomerName = order.Order.OrderItems.,
                Items = order.Order.OrderItems.Select(i => new OrderDto.OrderItemDto
                {
                    ProductId = i.Product.Id,
                    ProductName = i.Product.Name,
                    Price = i.Product.Price,
                    Quantity = i.Quantity,
                    TotalPrice = i.TotalPrice
                }).ToList()
            };
        }
    }

}
