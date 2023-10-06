using Hamburger_DAL.Context;
using Hamburger_DAL.Repository.Interfaces;
using Hamburger_DATA.Abstract;
using Hamburger_DATA.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DAL.Repository.Concrete
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        private DbSet<T> _table;
        public BaseRepo(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity is not null)
            {
                _table.Add(entity);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity is not null)
            {
                entity.DeleteDate = DateTime.Now;
                entity.Status = Status.Passive;
                _table.Update(entity);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }
        public IEnumerable<T> GetAll()
        {
            return _table.Where(x => x.Status != Status.Passive);
        }

        public T GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Status != Status.Passive && x.Id==id);
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _table;

            if (join != null)
            {
                query = join(_table);
            }
            if (where != null)
            {
                query = query.Where(where);
            }
            if (orderBy != null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }

        public void Update(T entity)
        {
            if (entity is not null)
            {
                entity.UpdateDate = DateTime.Now;
                entity.Status = Status.Modified;
                _table.Update(entity);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }
    }
}
