﻿using E_CommerceAPI.Application.Repositories;
using E_CommerceAPI.Domain.Entities.Common;
using E_CommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIDbContext _context;

        public WriteRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> EntityEntry = await Table.AddAsync(model);
            return EntityEntry.State == EntityState.Added;
        }
        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
           EntityEntry<T> entityEntry= Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;     
        }

        public async Task<bool> RemoveAsync(string id)
        {
           T model= await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
           return Remove(model);
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public Task<int> SaveAsync()
            => _context.SaveChangesAsync();

        public bool Update(T model)
        {
           EntityEntry<T> entityEntry= Table.Update(model);
           return entityEntry.State == EntityState.Modified;
            
        }
    }
}
