using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    public class RepositoryBase<TEntity, TPK> : IRepository<TEntity, TPK> where TEntity : BaseEntity<TPK>
    {
        protected readonly Microsoft.EntityFrameworkCore.DbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(Microsoft.EntityFrameworkCore.DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
            => _dbSet.ToList();

        public TEntity GetById(TPK id)
            => _dbSet.Find(id);

        public void Update(TEntity entity)
        {
            var result = _dbSet.Find(entity.id);
            if (result != null)
                _context.Entry(result).CurrentValues.SetValues(entity);
        }

        public virtual void Delete(TPK id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public virtual void Insert(TEntity entity)
            => _dbSet.Add(entity);

        public virtual void SaveChanges()
            => _context.SaveChanges();
    }
}
