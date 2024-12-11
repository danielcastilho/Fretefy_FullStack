using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Fretefy.Test.Domain.Services
{
    public abstract class ServiceBase<T> : IGenericService<T>
        where T : class, IEntity
    {
        protected readonly IGenericRepository<T> _repository;

        public ServiceBase(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> Create(T newEntity)
        {
            var modelState = Validate(newEntity);
            return await _repository.Create(newEntity);
        }

        public virtual async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }

        public virtual async Task<T> Get(Guid id)
        {
            return await _repository.Get(id);
        }

        public virtual async Task<IEnumerable<T>> List()
        {
            return await _repository.List();
        }

        public virtual async Task<IEnumerable<T>> Query(string terms)
        {
            return await _repository.Query(terms);
        }

        public virtual async Task<ModelStateDictionary> Update(
            Guid id,
            JsonPatchDocument<T> values,
            ModelStateDictionary modelState
        )
        {
            var entity = await Get(id);
            if (entity == null)
            {
                modelState.AddModelError("id", "Entity not found");
                return modelState;
            }
            values.ApplyTo(
                entity,
                e =>
                {
                    modelState.AddModelError(e.Operation.path, e.ErrorMessage);
                }
            );
            modelState = await Validate(entity, modelState);
            var result = await _repository.Update(id, entity);
            if (!result)
                modelState.AddModelError($"id: {id}", "Update failed");
            return modelState;
        }

        public virtual async Task<ModelStateDictionary> Validate(T entity, ModelStateDictionary modelState = null)
        {
            modelState = modelState ?? new ModelStateDictionary();
            var validationResults = new List<ValidationResult>();
            var success = Validator.TryValidateObject(entity, new ValidationContext(entity), validationResults, true);
            if (!success)
            {
                foreach (var validationResult in validationResults)
                {
                    modelState.AddModelError(
                        string.Join(", ", validationResult.MemberNames),
                        validationResult.ErrorMessage
                    );
                }
                return modelState;
            }
            await Task.Yield();
            return modelState;
        }
    }
}
