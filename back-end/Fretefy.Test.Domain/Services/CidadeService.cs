using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Fretefy.Test.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private ICidadeRepository _cidadeRepository => base._repository as ICidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
            : base(cidadeRepository) { }

        public async Task<IEnumerable<Cidade>> ListByUf(string uf)
        {
            return await _cidadeRepository.ListByUf(uf);
        }

        private static bool ValidUF(string uf)
        {
            string[] ufs =
            {
                "AC",
                "AL",
                "AP",
                "AM",
                "BA",
                "CE",
                "DF",
                "ES",
                "GO",
                "MA",
                "MT",
                "MS",
                "MG",
                "PA",
                "PB",
                "PR",
                "PE",
                "PI",
                "RJ",
                "RN",
                "RS",
                "RO",
                "RR",
                "SC",
                "SP",
                "SE",
                "TO",
            };
            return Array.IndexOf(ufs, uf) >= 0;
        }

        public override async Task<ModelStateDictionary> Validate(Cidade entity, ModelStateDictionary modelState = null)
        {
            modelState = await Validate(entity, modelState);
            if (!ValidUF(entity.UF))
            {
                modelState.AddModelError("UF", "Invalid UF");
            }
            return modelState;
        }
    }
}
