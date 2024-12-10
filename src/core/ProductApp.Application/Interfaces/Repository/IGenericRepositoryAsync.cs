using System;
using Product.Domain.Common;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {

        Task<List<T>> GetAllAsync();

        Task<T> GetIdAsync(Guid Id);

        Task<T> AddAsync(T entity);
    }
}
