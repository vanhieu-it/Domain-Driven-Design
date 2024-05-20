using Domain_Driven_Design.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Specifications
{
    public class OrderSpecification
    {
        public bool IsSatisfiedBy(Order order)
        {
            // Example specification: Order must have at least one item
            return order.OrderItems.Count > 0;
        }
    }

}
