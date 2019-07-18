using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitedRemoteShopChallenge.API.Model;
using UnitedRemoteShopChallenge.Data.Model;
using UnitedRemoteShopChallenge.Data.Repositories;

namespace UnitedRemoteShopChallenge.API.Services
{
    public class UnitedRemoteService : UnitedRemoteServiceBase, IUnitedRemoteService
    {
        private readonly IRepository<Shop, Guid> _repositoryShop;
        private readonly IRepository<ShopsPreferred, Guid> _repositoryShopPreferred;
        private readonly IMapper _mapper;

        public UnitedRemoteService(IMapper mapper, IRepository<Shop, Guid> repositoryShop, IRepository<ShopsPreferred, Guid> repositoryShopPreferred)
        {
            _mapper = mapper;
            _repositoryShop = repositoryShop;
            _repositoryShopPreferred = repositoryShopPreferred;
        }


        public async Task<List<ShopDto>> GetShops()
        {
            var allshops = await _repositoryShop.GetAllListAsync();
            return _mapper.Map<List<ShopDto>>(allshops);
        }

        public async Task<List<ShopsPreferredDto>> GetShopsPreferredDto(Guid userId)
        {
            var allShopsDto = await _repositoryShopPreferred.GetAllListAsync();
            return _mapper.Map<List<ShopsPreferredDto>>(allShopsDto);
        }

        public async Task<ShopsPreferredDto> LikeShops(ShopsPreferredDto shopDto)
        {
            var shopPreferred = Mapper.Map<ShopsPreferred>(shopDto);
            return _mapper.Map<ShopsPreferredDto>(await _repositoryShopPreferred.InsertAsync(shopPreferred));
        }
        public async void DisLikeShops(ShopsPreferredDto shopDto)
        {
            var shopPreferred = Mapper.Map<ShopsPreferred>(shopDto);
            await _repositoryShopPreferred.DeleteAsync(shopPreferred);
        }

    }
}
