using ApplicationCore.Entity;
using ApplicationCore.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataContext
{
    /// <summary>
    /// "There's some repetition here - couldn't we have some the sync methods call the async?"
    /// https://blogs.msdn.microsoft.com/pfxteam/2012/04/13/should-i-expose-synchronous-wrappers-for-asynchronous-methods/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EfRepository<T> : IRepository<T>, IRepositoryAsync<T> where T : BaseEntity
    {
        protected readonly SystemDbContext systemDbContext;

        public EfRepository(SystemDbContext systemDbContext)
        {
            this.systemDbContext = systemDbContext;
        }

        public virtual T GetById(int id)
        {
            return systemDbContext.Set<T>().Find(id);
        }

        public T GetSingleBySpec(ISpecification<T> spec)
        {
            return List(spec).FirstOrDefault();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await systemDbContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> ListAll()
        {
            return systemDbContext.Set<T>().AsEnumerable();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await systemDbContext.Set<T>().ToListAsync();
        }

        public IEnumerable<T> List(ISpecification<T> spec)
        {
            return ApplySpecification(spec).AsEnumerable();
        }
        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public T Add(T entity)
        {
            systemDbContext.Set<T>().Add(entity);
            systemDbContext.SaveChanges();

            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            systemDbContext.Set<T>().Add(entity);
            await systemDbContext.SaveChangesAsync();

            return entity;
        }

        public void Update(T entity)
        {
            systemDbContext.Entry(entity).State = EntityState.Modified;
            systemDbContext.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            systemDbContext.Entry(entity).State = EntityState.Modified;
            await systemDbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            systemDbContext.Set<T>().Remove(entity);
            systemDbContext.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            systemDbContext.Set<T>().Remove(entity);
            await systemDbContext.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(systemDbContext.Set<T>().AsQueryable(), spec);
        }
    }
}
