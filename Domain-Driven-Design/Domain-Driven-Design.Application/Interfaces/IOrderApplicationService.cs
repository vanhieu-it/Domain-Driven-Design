using Domain_Driven_Design.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Application.Interfaces
{
    public interface IOrderApplicationService
    {
        OrderDto GetOrderById(Guid orderId);
    }

}
