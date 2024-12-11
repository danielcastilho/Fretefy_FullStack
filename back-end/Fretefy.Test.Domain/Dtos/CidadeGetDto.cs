using System;

namespace Fretefy.Test.Domain.Dtos
{
    public record CidadeGetDto(Guid Id, string Nome, Guid? RegiaoId, string RegiaoNome)
    {
        public CidadeGetDto()
            : this(Guid.Empty, string.Empty, null, string.Empty) { }
    }
}
