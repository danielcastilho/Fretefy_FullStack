using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RepositoryBase<T> : IGenericRepository<T> where T : class, IEntity
    {
        protected DbSet<T> _dbSet;
        protected readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> List()
        {
            return await _dbSet.ToListAsync<T>();
        }

        public async Task<IEnumerable<T>> Query(string terms)
        {
            return await _dbSet.Where(e => e.ToString().Contains(terms)).ToListAsync();
        }

        public async Task<T> Get(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Create(T newEntity)
        {
            await _dbSet.AddAsync(newEntity);
            await _context.SaveChangesAsync();
            return newEntity;
        }

        public async Task<bool> Update(Guid id, T entityValues)
        {
            var entity = await Get(id);
            if (entity == null) return false;
            
            _context.Entry(entity).CurrentValues.SetValues(entityValues);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(Guid id, Dictionary<string, object> values)
        {
            var entity = await Get(id);
            if (entity == null) return false;

            foreach (var item in values)
            {
                _context.Entry(entity).Property(item.Key).CurrentValue = item.Value;
            }
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Guid id)
        {
            var entity = await Get(id);
            if (entity == null) return false;

            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        
    }
}