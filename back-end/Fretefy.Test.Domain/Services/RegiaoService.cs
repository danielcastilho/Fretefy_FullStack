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
    public class RegiaoService : ServiceBase<Regiao>, IRegiaoService
    {
        private IRegiaoRepository RegiaoRepository => base._repository as IRegiaoRepository;
        private readonly ICidadeRepository cidadeRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository, ICidadeRepository cidadeRepository)
            : base(regiaoRepository)
        {
            this.cidadeRepository = cidadeRepository;
        }

        public override async Task<ModelStateDictionary> Validate(Regiao entity, ModelStateDictionary modelState = null)
        {
            modelState = await base.Validate(entity, modelState);
            bool unique = await CheckUniqueName(entity);
            if (!unique)
            {
                modelState.AddModelError("Nome", "Nome já cadastrado");
            }
            //check if all cities are valid
            foreach (var cidade in entity.Cidades)
            {
                var cidadeEntity = await cidadeRepository.Get(cidade.Id);
                if (cidadeEntity == null)
                {
                    modelState.AddModelError("Cidades", $"Cidade com id: {cidade.Id} não encontrada");
                }
                else
                {
                    if (!entity.Cidades.Contains(cidadeEntity))
                        entity.Cidades.Add(cidadeEntity);
                }
            }
            return modelState;
        }

        private async Task<bool> CheckUniqueName(Regiao regiao)
        {
            var anotherRegiao = await RegiaoRepository.GetByNome(regiao.Nome);
            if (anotherRegiao == null || anotherRegiao.Id == regiao.Id)
            {
                return true;
            }
            return false;
        }

        public override async Task<Regiao> Create(Regiao newEntity)
        {
            var modelState = await Validate(newEntity);
            if (modelState.IsValid)
            {
                return await base.Create(newEntity);
            }
            return null;
        }
    }
}
