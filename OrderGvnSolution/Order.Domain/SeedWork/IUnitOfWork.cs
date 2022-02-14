﻿using System;
using System.Threading.Tasks;

namespace Order.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        Task<Guid> SaveChanges();
    }
}