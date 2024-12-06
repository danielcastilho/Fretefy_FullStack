using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            _ = builder.HasKey(p => p.Id);
            _ = builder.Property(p => p.Nome).HasMaxLength(1024).IsRequired();
            _ = builder.Property(p => p.UF).HasMaxLength(2).IsRequired();

            _ = builder.HasData(
                new Cidade { Nome = "Rio Branco", UF = "AC" },
                new Cidade { Nome = "Maceió", UF = "AL" },
                new Cidade { Nome = "Macapá", UF = "AP" },
                new Cidade { Nome = "Manaus", UF = "AM" },
                new Cidade { Nome = "Salvador", UF = "BA" },
                new Cidade { Nome = "Fortaleza", UF = "CE" },
                new Cidade { Nome = "Brasília", UF = "DF" },
                new Cidade { Nome = "Vitória", UF = "ES" },
                new Cidade { Nome = "Goiânia", UF = "GO" },
                new Cidade { Nome = "São Luís", UF = "MA" },
                new Cidade { Nome = "Cuiabá", UF = "MT" },
                new Cidade { Nome = "Campo Grande", UF = "MS" },
                new Cidade { Nome = "Belo Horizonte", UF = "MG" },
                new Cidade { Nome = "Belém", UF = "PA" },
                new Cidade { Nome = "João Pessoa", UF = "PB" },
                new Cidade { Nome = "Curitiba", UF = "PR" },
                new Cidade { Nome = "Recife", UF = "PE" },
                new Cidade { Nome = "Teresina", UF = "PI" },
                new Cidade { Nome = "Rio de Janeiro", UF = "RJ" },
                new Cidade { Nome = "Natal", UF = "RN" },
                new Cidade { Nome = "Porto Alegre", UF = "RS" },
                new Cidade { Nome = "Porto Velho", UF = "RO" },
                new Cidade { Nome = "Boa Vista", UF = "RR" },
                new Cidade { Nome = "Florianópolis", UF = "SC" },
                new Cidade { Nome = "São Paulo", UF = "SP" },
                new Cidade { Nome = "Aracaju", UF = "SE" },
                new Cidade { Nome = "Palmas", UF = "TO" }
            );
        }
    }
}
