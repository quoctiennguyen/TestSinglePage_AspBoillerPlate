using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Trainer.EntityFramework.Repositories
{
    public abstract class TrainerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TrainerDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TrainerRepositoryBase(IDbContextProvider<TrainerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TrainerRepositoryBase<TEntity> : TrainerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TrainerRepositoryBase(IDbContextProvider<TrainerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
