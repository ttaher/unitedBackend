using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitedRemoteShopChallenge.Data.Repositories;

namespace UnitedRemoteShopChallenge.Data.Model
{
    public class Shop:Entity<Guid>
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
