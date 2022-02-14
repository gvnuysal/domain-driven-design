using System;
using System.Collections.Generic;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order:BaseEntity<Guid>
    {
        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public Guid BayerId { get; private set; }
        public string OrderStatus { get; private set; }
        public Address Address { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, Guid bayerId, string orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
            {
                throw new Exception("Order date must be greater than today");
            }

            if (string.IsNullOrEmpty(address.City))
            {
                throw new Exception("City cannot be null");
            }
            
            OrderDate = orderDate;
            Description = description;
            BayerId = bayerId;
            OrderStatus = orderStatus;
            Address = address;
            OrderItems = orderItems;
        }

        public void AddOrderItem(int quantity, int price, Guid productId)
        {
            OrderItem orderItem = new(quantity,price,productId){ };
            OrderItems.Add(orderItem);
        }
    }
}