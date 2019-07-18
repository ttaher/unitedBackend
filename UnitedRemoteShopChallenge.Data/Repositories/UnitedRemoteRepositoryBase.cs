using UnitedRemoteShopChallenge.Data.Model;

namespace UnitedRemoteShopChallenge.Data.Repositories
{
    public class UnitedRemoteRepositoryBase<TEntity, TKey> : RepositoryBase<UnitedRemoteDbContext, TEntity, TKey>
        where TEntity : Entity<TKey>
    {
        public UnitedRemoteRepositoryBase(UnitedRemoteDbContext context)
            : base(context)
        {
        }
    }
}
