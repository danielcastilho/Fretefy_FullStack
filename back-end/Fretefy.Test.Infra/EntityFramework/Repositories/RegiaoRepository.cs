using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : RepositoryBase<Regiao>, IRegiaoRepository
    {
        public RegiaoRepository(DbContext context) : base(context)
        {
        }
    }
}
