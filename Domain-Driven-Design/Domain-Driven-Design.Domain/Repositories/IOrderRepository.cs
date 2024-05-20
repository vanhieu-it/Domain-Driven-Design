using Domain_Driven_Design.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Repositories
{
    public interface IOrderRepository
    {
        void Save(OrderAggregate order);
        OrderAggregate GetById(Guid id);
    }
}
