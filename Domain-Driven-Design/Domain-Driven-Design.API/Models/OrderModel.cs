﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain_Driven_Design.API.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItemModel> Items { get; set; } = new List<OrderItemModel>();

        public class OrderItemModel
        {
            public Guid ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        }
    }

}