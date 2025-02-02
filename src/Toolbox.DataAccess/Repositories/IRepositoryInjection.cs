﻿using System.Data.Entity;

namespace Toolbox.DataAccess.Repositories
{
    public interface IRepositoryInjection<TContext> where TContext : DbContext
    {
        IRepositoryInjection<TContext> SetContext(TContext context);
    }
}