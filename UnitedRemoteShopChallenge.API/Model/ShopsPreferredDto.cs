using System;
using System.ComponentModel.DataAnnotations.Schema;
using UnitedRemoteShopChallenge.Data.Model;

namespace UnitedRemoteShopChallenge.API.Model
{
    public class ShopsPreferredDto:EntityDto<Guid>
    {
        public Guid ShopsPreferredId { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public IdnentityUser User { get; set; }
        public Guid ShopId { get; set; }
        [ForeignKey(nameof(ShopId))]
        public ShopDto Shop { get; set; }
    }
}
