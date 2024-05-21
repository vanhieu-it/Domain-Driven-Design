using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain_Driven_Design.API.ViewModels
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItemViewModel> Items { get; set; } = new List<OrderItemViewModel>();

        public class OrderItemViewModel
        {
            public Guid ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        }
    }

}