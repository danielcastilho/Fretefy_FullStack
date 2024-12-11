using System;

namespace Fretefy.Test.Domain.Dtos
{
    public record RegiaoUpdateDto(Guid Id, string Nome, Guid[] IdCidades)
    {
        public RegiaoUpdateDto()
            : this(Guid.Empty, string.Empty, Array.Empty<Guid>()) { }
    }
}
