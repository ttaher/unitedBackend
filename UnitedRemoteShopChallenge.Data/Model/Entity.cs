using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedRemoteShopChallenge.Data.Model
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }

    }
}
