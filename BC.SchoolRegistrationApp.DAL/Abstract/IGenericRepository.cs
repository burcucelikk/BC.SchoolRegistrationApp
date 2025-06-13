using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.Entity.Abstracts
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        T? GetById(int id); // Id'ye göre getirir
        T? Get(Expression<Func<T, bool>> predicate); // Tek kayıt filtreyle
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // Hepsi ya da filtreli liste
        void Add(T entity); // Ekleme
        void Update(T entity); // Güncelleme
        void Delete(T entity); // Silme
        IQueryable<T> GetQueryable(); // Sorgulanabilir hale getir

    }
}
