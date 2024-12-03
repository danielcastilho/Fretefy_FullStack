using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    // Interface genérica de repositórios para funcionalidades comuns
    public interface IGenericRepository<T> where T : IEntity
    {
        IQueryable<T> List();
        IEnumerable<T> Query(string terms);
    }
 
}
