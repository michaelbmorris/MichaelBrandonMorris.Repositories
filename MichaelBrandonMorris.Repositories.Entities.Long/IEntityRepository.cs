using MichaelBrandonMorris.Entities.Long;

namespace MichaelBrandonMorris.Repositories.Entities.Long
{
    public interface IEntityRepository<TEntity> : IEntityRepository<TEntity, long> where TEntity : Entity
    {
    }

    public interface IEntityRepositoryAsync<TEntity> : IEntityRepositoryAsync<TEntity, long> where TEntity : Entity
    {
    }
}
