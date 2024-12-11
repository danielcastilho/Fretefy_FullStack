using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Fretefy.Test.WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Dtos.CidadeGetDto, Domain.Entities.Cidade>();
            CreateMap<Domain.Dtos.CidadeNewDto, Domain.Entities.Cidade>();
            CreateMap<Domain.Dtos.CidadeUpdateDto, Domain.Entities.Cidade>();
            CreateMap<Domain.Dtos.RegiaoGetDto, Domain.Entities.Regiao>();
            CreateMap<Domain.Dtos.RegiaoNewDto, Domain.Entities.Regiao>();
            CreateMap<Domain.Dtos.RegiaoUpdateDto, Domain.Entities.Regiao>();
            CreateMap<Domain.Entities.Cidade, Domain.Dtos.CidadeGetDto>();
            CreateMap<Domain.Entities.Regiao, Domain.Dtos.RegiaoGetDto>();
        }
    }
}
