using Domain_Driven_Design.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.Commands
{
    public class AddOrderItemCommand
    {
        public Guid OrderId { get; }
        public Product Product { get; }
        public int Quantity { get; }

        public AddOrderItemCommand(Guid orderId, Product product, int quantity)
        {
            OrderId = orderId;
            Product = product;
            Quantity = quantity;
        }
    }

}
