using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface ICidadeService : IGenericService<Cidade>
    {
        Task<IEnumerable<Cidade>> ListByUf(string uf);
    }
}
