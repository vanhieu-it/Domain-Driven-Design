using Domain_Driven_Design.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Events
{
    public class OrderItemAddedEvent : Event
    {
        public Guid OrderId { get; }
        public OrderItem OrderItem { get; }

        public OrderItemAddedEvent(Guid orderId, OrderItem orderItem)
        {
            OrderId = orderId;
            OrderItem = orderItem;
        }
    }
}
