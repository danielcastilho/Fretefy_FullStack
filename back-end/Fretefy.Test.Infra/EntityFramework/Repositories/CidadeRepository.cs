using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(DbContext dbContext)
            : base(dbContext)
        {
            _dbSet = dbContext.Set<Cidade>();
        }

        public async Task<IEnumerable<Cidade>> ListByUf(string uf)
        {
            return await _dbSet.Where(w => EF.Functions.Like(w.UF, $"%{uf}%")).ToListAsync();
        }
    }
}
