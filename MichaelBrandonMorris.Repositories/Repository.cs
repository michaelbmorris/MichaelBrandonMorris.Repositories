using System.Data;
using MichaelBrandonMorris.Repositories.Configuration;

namespace MichaelBrandonMorris.Repositories
{
    public abstract class Repository
    {
        protected Repository(IRepositoryConfiguration repositoryConfiguration)
        {
            RepositoryConfiguration = repositoryConfiguration;
        }

        protected IRepositoryConfiguration RepositoryConfiguration { get; }

        protected abstract IDbConnection GetDbConnection();
    }
}
