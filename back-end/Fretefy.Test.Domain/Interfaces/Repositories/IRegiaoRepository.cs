using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository : IGenericRepository<Regiao>
    {
        // Funcionalidade específica de Região
        Task<Regiao> GetByNome(string nome);
    }
}
