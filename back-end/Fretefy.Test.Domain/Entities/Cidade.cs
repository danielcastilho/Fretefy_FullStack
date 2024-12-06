#nullable enable
using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Cidade : IEntity
    {
        public Cidade()
        {
            Id = Guid.NewGuid();
        }

        public Cidade(string nome, string uf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
        }

        public Guid Id { get; set; }

        public required string Nome { get; set; }

        public required string UF { get; set; }

        // public ICollection<Regiao>? Regioes { get; set; } = 
        //     new List<Regiao>(); // Na prática será possível apenas 0 ou 1 região
    }
}
