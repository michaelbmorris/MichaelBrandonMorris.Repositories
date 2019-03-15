namespace MichaelBrandonMorris.Repositories
{
    public class RepositoryConfiguration : IRepositoryConfiguration
    {
        public string ConnectionString { get; set; }
    }

    public interface IRepositoryConfiguration
    {
        string ConnectionString { get; set; }
    }
}
