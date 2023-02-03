using DBSampleConsole.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DBSampleConsole.Repositories
{
    public abstract class Repository<TEntity> 
     where TEntity : class
    {
        private readonly MyDBContext context;

        protected Repository(MyDBContext context)
        {
            this.context = context;
        }
        public virtual TEntity Add(TEntity entity)
        {
            context.Add(entity);
            return entity;
        }
        public virtual TEntity Update(TEntity entity)
        {
            context.Update(entity);
            return entity;
        }
        public virtual void Remove(TEntity entity)
        {
            context.Remove(entity);
        }

        public virtual List<TEntity> GetAll() {
            return context.Set<TEntity>().ToList();
        }

        public virtual TEntity? FindById(int id)
        {
            return context.Set<TEntity>()
                .Where(w => EF.Property<int>(w, "Id") == id)
                .FirstOrDefault();
        }
        public virtual List<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

     }
}
