using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace Isus2017CoreSpa.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class Isus2017CoreSpaRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<Isus2017CoreSpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Isus2017CoreSpaRepositoryBase(IDbContextProvider<Isus2017CoreSpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="Isus2017CoreSpaRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class Isus2017CoreSpaRepositoryBase<TEntity> : Isus2017CoreSpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected Isus2017CoreSpaRepositoryBase(IDbContextProvider<Isus2017CoreSpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
