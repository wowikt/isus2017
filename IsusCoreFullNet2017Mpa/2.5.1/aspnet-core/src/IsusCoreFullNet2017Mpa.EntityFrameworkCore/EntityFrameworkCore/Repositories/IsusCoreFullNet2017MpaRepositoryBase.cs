using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace IsusCoreFullNet2017Mpa.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class IsusCoreFullNet2017MpaRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<IsusCoreFullNet2017MpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected IsusCoreFullNet2017MpaRepositoryBase(IDbContextProvider<IsusCoreFullNet2017MpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="IsusCoreFullNet2017MpaRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class IsusCoreFullNet2017MpaRepositoryBase<TEntity> : IsusCoreFullNet2017MpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected IsusCoreFullNet2017MpaRepositoryBase(IDbContextProvider<IsusCoreFullNet2017MpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
