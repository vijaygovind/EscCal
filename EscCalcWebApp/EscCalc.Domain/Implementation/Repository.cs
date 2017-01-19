using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EscCalc.Domain.Abstract;
using EscCalc.Domain.Entities.Models;
using EscCalc.Domain.Entities.MyEntities;
using System.Runtime.Remoting.Contexts;
using EscCalc.Domain.Entities;

namespace EscCalc.Domain.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        CasePropertiesContext context = new CasePropertiesContext();

        //DbSet usable with any of our entity types
        protected DbSet<TEntity> dbSet;

        public Repository(DbContext context)
        {
            Context = context;
            dbSet = context.Set<TEntity>();
        }

        public Repository()
        {
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public TEntity Get(int Id)
        {
            return dbSet.Find(Id);
        }

        //Implementation of IRepository methods
        public virtual IEnumerable<TEntity> GetAll
        {
            get
            {
                return dbSet;
            }
        }

        //IDisposable implementation
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
        public void add(TxnCase cs)
        {

            context.cases.Add(cs);
            context.SaveChanges();
        }

        public void add(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
