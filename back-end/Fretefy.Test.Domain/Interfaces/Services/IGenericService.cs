using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IGenericService<T>
        where T : class, IEntity
    {
        Task<T> Get(Guid id);
        Task<T> Create(T newEntity);
        Task<ModelStateDictionary> Validate(T entity, ModelStateDictionary modelState = null);
        Task<ModelStateDictionary> Update(Guid id, JsonPatchDocument<T> values, ModelStateDictionary modelState);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<T>> List();
        Task<IEnumerable<T>> Query(string terms);
    }
}
