using System;
using System.Threading.Tasks;
using Order.Application.Repository;

namespace Order.Infrastructure.Repository
{
    public class OrderRepository:IOrderRepository
    {
        public async Task<Guid> SaveChanges()
        {
            return await Task.FromResult(Guid.NewGuid());
        }
    }
}