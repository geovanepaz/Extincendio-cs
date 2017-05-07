using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Extincendio.Domain.Interfaces.Repositories;
using Extincendio.Infra.Data.Contexto;

namespace Extincendio.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ExtincendioContext Db = new ExtincendioContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();

        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();

        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();

        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
          
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

      
    }
}
