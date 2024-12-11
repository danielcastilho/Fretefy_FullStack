using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IGenericRepository<Cidade>
    {
        Task<IEnumerable<Cidade>> ListByUf(string uf);
    }
}
