using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.Commands
{
    public class CreateOrderCommand
    {
        public Guid OrderId { get; }
        public string CustomerName { get; }

        public CreateOrderCommand(Guid orderId, string customerName)
        {
            OrderId = orderId;
            CustomerName = customerName;
        }
    }

}
