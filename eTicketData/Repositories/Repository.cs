﻿using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace eTicketData.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly Microsoft.EntityFrameworkCore.DbSet<TEntity> _entities;

        public Repository(ApplicationDbContext context, IHttpContextAccessor httpAccessor)
        {
            _context = context;
            _entities = context.Set<TEntity>();
            context.CurrentUserId = httpAccessor.HttpContext.User?.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value?.Trim();
        }

        //private readonly ApplicationDbContext _context;

        //public EventRepository(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public virtual void Add(TEntity entity)
        {
            _entities.Add(entity);
          
          
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }


        public virtual void Update(TEntity entity)
        {
            object value = _entities.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<TEntity> entities)
        {
            _entities.UpdateRange(entities);
        }

        public virtual void Remove(TEntity entity)
        {
            if (entity is Entities.IAuditableEntity)
            {

                var prop = entity.GetType().GetProperty("Status");
                prop.SetValue(entity, false);
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

            }
            else
                _entities.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var e in entities)
            {
                if (e is Entities.IAuditableEntity)
                {
                    e.GetType().GetProperty("Status").SetValue(e, false);
                }
                else
                    _entities.Remove(e);
            }
        }

        public virtual int Count()
        {
            var alle = _entities.ToList();
            return _entities.Count();
        }


        public virtual IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            var ent = _entities.Where(predicate);
            return ent;
        }

        public virtual TEntity GetSingleOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            var temp = _entities.FirstOrDefault(predicate);
            if (temp != null)
            {
                return temp;
            }
            return null;
        }

        public virtual TEntity Get(int id)
        {

            var temp = _entities.Find(id);
            if (temp != null)
            {
                return temp;
            }
            return null;
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
           // Expression<Func<Event, bool>> isTeenAgerExpr = s => s.IsActive==true;
            var all = _entities.ToList();
            return all;
        }
        public virtual async Task<TEntity> GetAsync(int id)
        {
            var temp = await _entities.FindAsync(id);
            if (temp != null)
            {
                return temp;
            }
            return null;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var all = await _entities.ToListAsync();
            return all;
        }

        public IQueryable<TEntity> GetAllQueryable()
        {
            return _entities;
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
