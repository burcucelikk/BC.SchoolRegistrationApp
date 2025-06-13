
using BC.SchoolRegistrationApp.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.DAL.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        protected DbContext _dbContext;
        protected DbSet<T> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)=> _dbContext.Add(entity);

        public void Delete(T entity)=> _dbContext.Remove(entity);
            
        public T? Get(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefault(predicate);

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)=> filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();

        public T? GetById(int id)=> _dbSet.Where(x => x.ID == id).FirstOrDefault();

        public IQueryable<T> GetQueryable()=> _dbSet.AsQueryable();

        public void Update(T entity) => _dbContext.Entry(entity).State = EntityState.Modified;
    }
}
