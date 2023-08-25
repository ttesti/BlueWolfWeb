using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BlueWolf.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetValue(Expression<Func<T, bool>> Filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        

    }
}
