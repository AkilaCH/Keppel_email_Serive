using Azbil.Billing.Data.Interfaces;
using Azbil.Billing.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Data
{
    public class Repository<TContext> : ReadOnlyRepository<TContext>, IRepository, IUmsRepository
    where TContext : DbContext
    {
        public Repository(TContext context)
            : base(context)
        {
        }

        public virtual void Create<TEntity>(TEntity entity, string createdBy = null)
            where TEntity : class, IEntity
        {
            context.Set<TEntity>().Add(entity);
        }

        public virtual void CreateList<TEntity>(List<TEntity> entities, string createdBy = null)
          where TEntity : class, IEntity
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public virtual void Update<TEntity>(TEntity entity, object modified = null)
            where TEntity : class, IEntity
        {
            context.Set<TEntity>().Attach(entity);

            if (null == modified)
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                context.Configuration.ValidateOnSaveEnabled = false;
                var entry = context.Entry(entity);

                foreach (PropertyInfo property in modified.GetType().GetProperties())
                {
                    entry.Property(property.Name).IsModified = true;
                }
            }
        }

        public virtual void Delete<TEntity>(object id)
            where TEntity : class, IEntity
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            Delete(entity);
        }

        public virtual void Delete<TEntity>(TEntity entity)
            where TEntity : class, IEntity
        {
            var dbSet = context.Set<TEntity>();
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public virtual void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                ThrowEnhancedValidationException(e);
            }
        }

        public virtual Task SaveAsync()
        {
            try
            {
                return context.SaveChangesAsync();
            }
            catch (DbEntityValidationException e)
            {
                ThrowEnhancedValidationException(e);
            }

            return Task.FromResult(0);
        }

        protected virtual void ThrowEnhancedValidationException(DbEntityValidationException e)
        {
            var errorMessages = e.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

            var fullErrorMessage = string.Join("; ", errorMessages);
            var exceptionMessage = string.Concat(e.Message, " The validation errors are: ", fullErrorMessage);
            throw new DbEntityValidationException(exceptionMessage, e.EntityValidationErrors);
        }

        public virtual void SqlQuery<TEntity>(string sqlQuery) where TEntity : class, IEntity
        {
            context.Database.ExecuteSqlCommand(sqlQuery);
        }
    }
}
