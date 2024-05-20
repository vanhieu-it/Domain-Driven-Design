using Domain_Driven_Design.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Aggregates
{
    public class OrderAggregate
    {
        public Order Order { get; private set; }

        public OrderAggregate(Guid id, string customerName)
        {
            Order = new Order(id, customerName);
        }

        public void AddOrderItem(Product product, int quantity)
        {
            Order.AddItem(product, quantity);
        }
    }

}
