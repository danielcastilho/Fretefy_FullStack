using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public abstract class ServiceBase<T> : IGenericService<T> where T : IEntity
    {
        protected readonly IGenericRepository<T> _repository;

        public ServiceBase(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public T Get(Guid id)
        {
            return _repository.List().FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<T> List()
        {
            return _repository.List();
        }

        public IEnumerable<T> Query(string terms)
        {
            return _repository.Query(terms);
        }
    }
}
