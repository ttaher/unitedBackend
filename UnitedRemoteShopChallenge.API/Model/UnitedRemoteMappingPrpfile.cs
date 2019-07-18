using AutoMapper;
using System.Collections.Generic;
using UnitedRemoteShopChallenge.API.Model;
using UnitedRemoteShopChallenge.Data.Model;

namespace UnitedRemoteShopChallenge.API.Model
{
    public class UnitedRemoteMappingPrpfile : Profile
    {
        public UnitedRemoteMappingPrpfile()
        {
            CreateMap<Shop, ShopDto>().ReverseMap();
            CreateMap<List<Shop>, List<ShopDto>>().ReverseMap();
            CreateMap<ShopsPreferred, ShopsPreferredDto>().ReverseMap();

            CreateMap<List<ShopsPreferred>, List<ShopsPreferredDto>>().ReverseMap();

        }
    }
}
