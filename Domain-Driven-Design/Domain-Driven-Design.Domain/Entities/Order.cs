using Domain_Driven_Design.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }
        public List<Event> Events { get; private set; }

        public Order()
        {
            OrderId = Guid.NewGuid();
            OrderDate = DateTime.UtcNow;
            OrderItems = new List<OrderItem>();
            Events = new List<Event>();
        }

        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
            // Thêm một sự kiện vào danh sách các sự kiện
            Events.Add(new OrderItemAddedEvent(OrderId, item));
        }
    }
}
