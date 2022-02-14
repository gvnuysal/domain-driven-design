using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Order.Application.Repository;
using Order.Domain.Events;

namespace Order.Application.DomainEventHandlers
{
    public class OrderStartedDomainEventHandler:INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository _buyerRepository;

        public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            
        }
    }
}