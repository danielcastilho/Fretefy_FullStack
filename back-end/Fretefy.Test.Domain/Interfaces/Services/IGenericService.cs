using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IGenericService<T> where T : IEntity
    {
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> List();
        Task<IEnumerable<T>> Query(string terms);
    }

}