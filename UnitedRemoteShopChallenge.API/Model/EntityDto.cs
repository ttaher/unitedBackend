using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedRemoteShopChallenge.API.Model
{
    public class EntityDto<TKey> : IEntityDto<TKey>
    {
        public TKey Id { get; set; }

    }
}
