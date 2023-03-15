using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Testeando.AngularJS.EntityFramework.Repositories
{
    public abstract class AngularJSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AngularJSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AngularJSRepositoryBase(IDbContextProvider<AngularJSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AngularJSRepositoryBase<TEntity> : AngularJSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AngularJSRepositoryBase(IDbContextProvider<AngularJSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
