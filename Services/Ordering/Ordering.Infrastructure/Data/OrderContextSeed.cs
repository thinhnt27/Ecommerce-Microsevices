using Microsoft.Extensions.Logging;
using Ordering.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Data
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation($"Ordering Database: {typeof(OrderContext).Name} seeded!!!");
            }
        }

        private static IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new()
                {
                    UserName = "Thinhnt",
                    FirstName = "Thinhnt",
                    LastName = "NT",
                    EmailAddress = "thinhnt@eCommerce.net",
                    AddressLine = "HCM",
                    Country = "VN",
                    TotalPrice = 750,
                    State = "KA",
                    ZipCode = "560001",

                    CardName = "Visa",
                    CardNumber = "1234567890123456",
                    CreatedBy = "Thinhnt",
                    Expiration = "12/25",
                    Cvv = "123",
                    PaymentMethod = 1,
                    LastModifiedBy = "Thinhnt",
                    LastModifiedDate = new DateTime(),
                }
            };
        }
    }
}
