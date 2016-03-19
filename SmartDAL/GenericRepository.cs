﻿using SmartModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SmartDAL
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IGenericModel
    {
        internal SmartContext Context;
        internal DbSet<TEntity> DbSet;

        public GenericRepository(SmartContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public GenericRepository()
        {

        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            var query = DbSet.ToList<TEntity>().AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            if (entityToUpdate == null)
            {
                throw new ArgumentException("Cannot add a null entity.");
            }
            var entry = Context.Entry<TEntity>(entityToUpdate);

            if (entry.State == EntityState.Detached)
            {
                var set = Context.Set<TEntity>();
                TEntity attachedEntity = set.Local.SingleOrDefault(e => e.Id == entityToUpdate.Id); // You need to have access to key

                if (attachedEntity != null)
                {
                    var attachedEntry = Context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entityToUpdate);
                }
                else
                {
                    entry.State = EntityState.Modified; 
                }
            }
        }

    }
}
