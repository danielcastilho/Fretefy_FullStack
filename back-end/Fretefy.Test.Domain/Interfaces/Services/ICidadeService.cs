﻿using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface ICidadeService : IGenericService<Cidade>
    {
        IEnumerable<Cidade> ListByUf(string uf);
    }
}
