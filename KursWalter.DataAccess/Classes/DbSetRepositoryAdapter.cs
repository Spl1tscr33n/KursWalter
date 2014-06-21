using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;
using KursWalter.DataAccess.Interfaces;
using System.Data.Entity;

namespace KursWalter.DataAccess.Classes
{
    class DbSetRepositoryAdapter<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public DbSetRepositoryAdapter(DbSet<T> dbSet)
        {
            if (dbSet == null) throw new ArgumentNullException("dbSet");
            this._dbSet = dbSet;
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T FindByID(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }
    }
}
