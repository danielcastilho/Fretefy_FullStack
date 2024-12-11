using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : RepositoryBase<Regiao>, IRegiaoRepository
    {
        public RegiaoRepository(DbContext context)
            : base(context) { }

        public async Task<Regiao> GetByNome(string nome)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Nome == nome);
        }
    }
}
