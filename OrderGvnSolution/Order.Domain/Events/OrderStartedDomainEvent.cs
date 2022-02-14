using MediatR;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent:INotification
    {
        public AggregateModels.OrderModels.Order Order { get; set; }
    }
}