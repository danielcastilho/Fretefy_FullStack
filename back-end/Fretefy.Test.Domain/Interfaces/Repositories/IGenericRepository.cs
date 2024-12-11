using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    // Interface genérica de repositórios para funcionalidades comuns
    public interface IGenericRepository<T>
        where T : class, IEntity
    {
        Task<IEnumerable<T>> List();
        Task<IEnumerable<T>> Query(string terms);
        Task<T> Get(Guid id);
        Task<T> Create(T newEntity);

        Task<bool> Update(Guid id, T values);
        Task<bool> Delete(Guid id);
    }
}
