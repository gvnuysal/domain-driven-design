﻿using System.Collections.Generic;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels
{
    public abstract class Address:ValueObject
    {
        public string City { get; set; }
        public string Country { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Country;
        }
    }
}