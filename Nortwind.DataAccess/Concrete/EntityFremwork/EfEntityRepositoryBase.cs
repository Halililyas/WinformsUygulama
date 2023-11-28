using Nortwind.DataAccess.Abstract;
using Nortwind.Entities.Abstract;
using Nortwind.Entities.Concrete.EntityFremwork;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFremwork
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityReposıtor<TEntity>
        where TEntity:class , IEntity,new()
      where TContext:DbContext,new()
    {
        public void Add(TEntity Entity)
        {
            using (TContext context =new TContext())
            {
                var AddedEntity = context.Entry(Entity);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
            }   
        }


        public void Delete(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var DeleteEntity = context.Entry(Entity);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var UpdateEntity = context.Entry(Entity);
                UpdateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
