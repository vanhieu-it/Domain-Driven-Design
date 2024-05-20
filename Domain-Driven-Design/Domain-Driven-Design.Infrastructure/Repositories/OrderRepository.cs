using Domain_Driven_Design.Domain.Aggregates;
using Domain_Driven_Design.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<OrderAggregate> _orders = new List<OrderAggregate>();

        public void Save(OrderAggregate order)
        {
            var existingOrder = _orders.FirstOrDefault(o => o.Order.Id == order.Order.Id);
            if (existingOrder == null)
            {
                _orders.Add(order);
            }
        }

        public OrderAggregate GetById(Guid id)
        {
            return _orders.FirstOrDefault(o => o.Order.Id == id);
        }
    }
}
