namespace UnitedRemoteShopChallenge.API.Model
{
    public interface IEntityDto<TKey>
    {
        TKey Id { get; set; }

    }
}