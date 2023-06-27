using System;
using System.Linq.Expressions;
using MagicVilla.API.Models;

namespace MagicVilla.API.Repositories.Interfaces
{
	public interface IBaseRepository<T> where T : BaseEntity
    {
		Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter);
        Task<T> GetAsync(Expression<Func<T, bool>>? filter, bool asTracking = false);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveChangesAysnc();
        
    }
}

