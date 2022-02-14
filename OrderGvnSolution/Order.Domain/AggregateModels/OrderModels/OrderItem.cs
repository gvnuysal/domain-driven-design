using System;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem:BaseEntity<Guid>
    {
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public Guid ProductId { get; private set; }

        public OrderItem(int quantity, decimal price, Guid productId)
        {
            //validation rules will be here
            
            Quantity = quantity;
            Price = price;
            ProductId = productId;
        }
    }
}