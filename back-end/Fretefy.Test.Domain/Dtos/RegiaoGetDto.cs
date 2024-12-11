using System;

namespace Fretefy.Test.Domain.Dtos
{
    public record RegiaoGetDto(Guid Id, string Nome, CidadeGetDto[] Cidades)
    {
        public RegiaoGetDto()
            : this(Guid.Empty, string.Empty, Array.Empty<CidadeGetDto>()) { }
    }
}
