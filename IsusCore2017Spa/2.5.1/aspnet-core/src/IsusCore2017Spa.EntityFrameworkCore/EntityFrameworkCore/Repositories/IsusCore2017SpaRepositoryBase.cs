using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace IsusCore2017Spa.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class IsusCore2017SpaRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<IsusCore2017SpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected IsusCore2017SpaRepositoryBase(IDbContextProvider<IsusCore2017SpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="IsusCore2017SpaRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class IsusCore2017SpaRepositoryBase<TEntity> : IsusCore2017SpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected IsusCore2017SpaRepositoryBase(IDbContextProvider<IsusCore2017SpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
