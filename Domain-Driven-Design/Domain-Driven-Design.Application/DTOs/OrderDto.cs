using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.DTOs
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();

        public class OrderItemDto
        {
            public Guid ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        }
    }

}
