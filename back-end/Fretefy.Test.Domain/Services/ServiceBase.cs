using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public abstract class ServiceBase<T> : IGenericService<T> where T : IEntity
    {
        protected readonly IGenericRepository<T> _repository;

        public ServiceBase(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<T> Get(Guid id)
        {
            return (await _repository.List()).FirstOrDefault(f => f.Id == id);
        }

        public async Task<IEnumerable<T>> List()
        {
            return await _repository.List();
        }

        public async Task<IEnumerable<T>> Query(string terms)
        {
            return await _repository.Query(terms);
        }
    }
}
