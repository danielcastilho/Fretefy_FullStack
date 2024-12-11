using System;

namespace Fretefy.Test.Domain.Dtos
{
    public record CidadeUpdateDto(Guid Id, string Nome, Guid? RegiaoId)
    {
        public CidadeUpdateDto()
            : this(Guid.Empty, string.Empty, null) { }
    }
}
