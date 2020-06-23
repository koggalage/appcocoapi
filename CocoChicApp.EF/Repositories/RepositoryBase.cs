using CocoChicApp.EF.Repositories.Interfaces;
using CocoChicApp.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CocoChicApp.EF.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        BeautyPro_COCOContext _context;
        protected readonly DbSet<TEntity> Entities;

        public RepositoryBase(BeautyPro_COCOContext context)
        {
            _context = context;
            Entities = _context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> All
        {
            get { return ObjectQuery; }
        }

        protected virtual IQueryable<TEntity> ObjectQuery
        {
            get
            {
                return Entities;
            }
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.FirstOrDefault(predicate);
        }

        public TEntity Get(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList();
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
        }

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Single(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.SingleOrDefault(predicate);
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Where(predicate);
        }
    }
}
