using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private ICidadeRepository _cidadeRepository => base._repository as ICidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository) : base(cidadeRepository) {}
        
        public IEnumerable<Cidade> ListByUf(string uf)
        {
            return _cidadeRepository.ListByUf(uf);
        }

    }
}
