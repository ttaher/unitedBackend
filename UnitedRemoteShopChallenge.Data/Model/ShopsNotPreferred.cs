using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitedRemoteShopChallenge.Data.Model
{
    public class ShopsNotPreferred:Entity<Guid>
    {
        public Guid ShopsPreferredId { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public IdnentityUser User { get; set; }
        public Guid ShopId { get; set; }
        [ForeignKey(nameof(ShopId))]
        public Shop Shop { get; set; }
    }
}
