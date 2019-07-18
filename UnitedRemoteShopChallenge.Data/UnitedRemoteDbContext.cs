using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using UnitedRemoteShopChallenge.Data.Model;

namespace UnitedRemoteShopChallenge.Data
{
    public class UnitedRemoteDbContext : IdentityDbContext<IdentityUser>
    {
        public UnitedRemoteDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopsNotPreferred> ShopsNotPreferreds { get; set; }
        public DbSet<ShopsPreferred> ShopsPreferred { get; set; }
    }
}
