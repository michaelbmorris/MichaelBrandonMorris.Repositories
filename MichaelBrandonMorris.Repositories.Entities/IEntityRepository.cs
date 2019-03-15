using System.Collections.Generic;
using System.Threading.Tasks;
using MichaelBrandonMorris.Entities;

namespace MichaelBrandonMorris.Repositories.Entities
{
    public interface IEntityRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        ISet<TEntity> All();
        TEntity FindById(TId id);
        int Create(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }

    public interface IEntityRepositoryAsync<TEntity, TId> where TEntity : Entity<TId>
    {
        Task<TEntity> FindByIdAsync(TId id);
        Task<ISet<TEntity>> AllAsync();
        Task<int> CreateAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
    }
}
