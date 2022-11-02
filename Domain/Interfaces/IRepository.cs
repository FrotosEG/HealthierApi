using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity, TPK> where TEntity : BaseEntity<TPK>
    {
        Task<IEnumerable<TEntity>> GetAllAsnc();
        Task<TEntity?> GetByIdAsync(TPK id);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TPK id);
        void SaveChanges();
    }
}
