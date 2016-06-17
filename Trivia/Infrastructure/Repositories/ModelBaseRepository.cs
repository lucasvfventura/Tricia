using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Trivia.Infrastructure.Repositories.Abstract;
using Trivia.Models;

namespace Trivia.Infrastructure.Repositories
{
    public class ModelBaseRepository<T> : IModelRepository<T> where T : class, IModelBase
    {
        protected TriviaContext context;

        public ModelBaseRepository(TriviaContext context)
        {
            this.context = context;
        }
        
        public void Add(T entity)
        {
            EntityEntry dbEntityEntry = context.Entry<T>(entity);
            context.Add<T>(entity);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            EntityEntry dbEntityEntry = context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void Edit(T entity)
        {
            EntityEntry dbEntityEntry = context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsEnumerable();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] properties)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (var property in properties)
            {
                query = query.Include(property);
            }
            return query.AsEnumerable();
        }

        public T GetSingle(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }
    }
}