using System;

namespace Fretefy.Test.Domain.Dtos
{
    public record RegiaoNewDto(string Nome, Guid[] IdCidades)
    {
        public RegiaoNewDto()
            : this(string.Empty, Array.Empty<Guid>()) { }
    }
}
