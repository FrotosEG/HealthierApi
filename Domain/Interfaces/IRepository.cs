using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity, TPK> where TEntity : BaseEntity<TPK>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TPK id);
        void Update(TEntity entity);
        void Delete(TPK id);
        void Insert(TEntity entity);
        void SaveChanges();
    }
}
