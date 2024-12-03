using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IGenericService<T> where T : IEntity
    {
        T Get(Guid id);
        IEnumerable<T> List();
        IEnumerable<T> Query(string terms);
    }

}