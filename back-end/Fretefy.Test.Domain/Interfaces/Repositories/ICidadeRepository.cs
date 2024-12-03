using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository: IGenericRepository<Cidade>
    {
        IEnumerable<Cidade> ListByUf(string uf);
    }
}
