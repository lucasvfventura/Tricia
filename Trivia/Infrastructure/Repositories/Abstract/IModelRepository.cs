using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Trivia.Models;

namespace Trivia.Infrastructure.Repositories.Abstract
{
    public interface IModelRepository<T> where T: class, IModelBase
    {
        T GetSingle(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] properties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Commit();
    }
}
