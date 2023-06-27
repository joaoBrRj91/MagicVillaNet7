using System;
using System.Linq.Expressions;
using MagicVilla.API.Data;
using MagicVilla.API.Models;
using MagicVilla.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.API.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly ApplicationDbContext applicationDb;

        public BaseRepository(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }

        public async Task CreateAsync(T entity)
        {
            await applicationDb.Set<T>().AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>>? filter, bool asTracking = false)
        {
            IQueryable<T> query = applicationDb.Set<T>();

            if (filter is not null)
                query = query.Where(filter);
            if (asTracking == false)
                query = query.AsNoTracking();

            var entity = await query.FirstOrDefaultAsync();
            return entity!;
        }

        public  async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter)
        {
            IQueryable<T> query = applicationDb.Set<T>();

            if (filter is not null)
                query = query.Where(filter);

            return await query.ToListAsync();
        }

        public async Task RemoveAsync(T entity)
        {

            await Task.Run(() =>
            {
                applicationDb.Set<T>().Remove(entity);
            });
        }


        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() =>
            {
                applicationDb.Set<T>().Update(entity);
            });
        }

        public async Task SaveChangesAysnc()
        {
            await applicationDb.SaveChangesAsync();
        }
    }
}

