using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using EscCalc.Domain.Entities.Models;

namespace EscCalc.Domain.Abstract   
{
    public interface IRepository<TEntity> : IDisposable where TEntity: class
    {
        TEntity Get(int Id);
        //IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll { get; }
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void add(TEntity entity);
      
    }
}
