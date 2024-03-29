﻿using System.Data;
using System.Data.SqlClient;
using MichaelBrandonMorris.Repositories.Configuration;

namespace MichaelBrandonMorris.Repositories.Sql
{
    public abstract class Repository : Repositories.Repository
    {
        protected Repository(IRepositoryConfiguration repositoryConfiguration) : base(repositoryConfiguration)
        {
        }

        protected override IDbConnection GetDbConnection()
        {
            return new SqlConnection(RepositoryConfiguration.ConnectionString);
        }
    }
}
