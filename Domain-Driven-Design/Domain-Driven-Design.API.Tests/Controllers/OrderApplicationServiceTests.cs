using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain_Driven_Design.API.Tests.Controllers
{
    [Fact]
    public void Can_Get_Order_By_Id()
    {
        var repository = new OrderRepository();
        var orderId = Guid.NewGuid();
        var order = new OrderAggregate(orderId, "Van Hieu");
        repository.Save(order);

        var service = new OrderApplicationService(repository);
        var dto = service.GetOrderById(orderId);

        Assert.NotNull(dto);
        Assert.Equal(orderId, dto.OrderId);
    }
}
