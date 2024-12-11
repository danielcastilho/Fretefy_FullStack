using System;

namespace Fretefy.Test.Domain.Dtos
{
    public record CidadeNewDto(string Nome, string UF, Guid? RegiaoId)
    {
        public CidadeNewDto()
            : this(string.Empty, string.Empty, null) { }
    }
}
