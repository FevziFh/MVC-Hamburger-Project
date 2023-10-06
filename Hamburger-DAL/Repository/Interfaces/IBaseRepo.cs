using Hamburger_DAL.Context;
using Hamburger_DATA.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DAL.Repository.Interfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                                Expression<Func<T, bool>> where,
                                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);
        public T GetDefault(Expression<Func<T, bool>> expression);

    }
}
