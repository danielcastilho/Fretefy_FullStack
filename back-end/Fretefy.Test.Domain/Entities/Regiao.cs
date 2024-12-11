using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
            Id = Guid.NewGuid();
            Cidades = new List<Cidade>();
        }

        public Regiao(string nome, IList<Cidade> cidades)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cidades = cidades;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<Cidade> Cidades { get; set; }
    }
}
