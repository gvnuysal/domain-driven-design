using System;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.BuyerModels.Buyer
{
    public class Buyer:BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}