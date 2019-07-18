using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitedRemoteShopChallenge.API.Model;

namespace UnitedRemoteShopChallenge.API.Services
{
    public interface IUnitedRemoteService  :IApplicationService
    {
        Task<List<ShopDto>> GetShops();
        Task<List<ShopsPreferredDto>> GetShopsPreferredDto(Guid userId);
        Task<ShopsPreferredDto> LikeShops(ShopsPreferredDto shopDto);
        void DisLikeShops(ShopsPreferredDto shopDto);
    }
}
