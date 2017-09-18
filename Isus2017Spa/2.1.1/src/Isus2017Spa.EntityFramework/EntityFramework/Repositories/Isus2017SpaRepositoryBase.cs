using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Isus2017Spa.EntityFramework.Repositories
{
    public abstract class Isus2017SpaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<Isus2017SpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Isus2017SpaRepositoryBase(IDbContextProvider<Isus2017SpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class Isus2017SpaRepositoryBase<TEntity> : Isus2017SpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected Isus2017SpaRepositoryBase(IDbContextProvider<Isus2017SpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
