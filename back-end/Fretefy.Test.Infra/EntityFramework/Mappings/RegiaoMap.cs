using System.Collections.Generic;
using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(1024).IsRequired();
            builder.HasMany<Cidade>(r=>r.Cidades)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasForeignKey("RegiaoId")
                .IsRequired(false);
            builder.Navigation(r => r.Cidades).AutoInclude(); // Include Cidades automatically in queries as desired in this test project
                                                               // Not recommended in production projects
                
        }
    }
}
