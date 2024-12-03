using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : ServiceBase<Regiao>, IRegiaoService
    {
        private IRegiaoRepository _RegiaoRepository => base._repository as IRegiaoRepository;

        public RegiaoService(IRegiaoRepository RegiaoRepository) : base(RegiaoRepository) {}
        

    }
}
