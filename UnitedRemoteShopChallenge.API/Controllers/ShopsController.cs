using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitedRemoteShopChallenge.API.Model;
using UnitedRemoteShopChallenge.API.Services;

namespace UnitedRemoteShopChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IUnitedRemoteService _unitedRemoteService;

        public ShopsController(IUnitedRemoteService unitedRemoteService)
        {
            _unitedRemoteService = unitedRemoteService;
        }

        // GET api/Shops
        [HttpGet]
        public async Task<List<ShopDto>> Get()
        {
            return await _unitedRemoteService.GetShops();
        }

        // GET api/ShopPreferred
        [HttpGet("ShopPreferred")]
        [Authorize]
        public async Task<List<ShopsPreferredDto>> ShopPreferred()
        {
            var userId = Guid.Parse(HttpContext.User.Claims.First().Value);

            return await _unitedRemoteService.GetShopsPreferredDto(userId);
        }

        // POST api/Like
        [HttpPost("Like")]
        [Authorize]
        public async Task<ShopsPreferredDto> Post(ShopsPreferredDto shopDto)
        {
            var userId = Guid.Parse(HttpContext.User.Claims.First().Value);
            shopDto.UserId = userId;
            return await _unitedRemoteService.LikeShops(shopDto);
        }

        // DELETE api/Dislike
        [HttpDelete("DisLike")]
        [Authorize]
        public void Delete(ShopsPreferredDto shopDto)
        {
            var userId = Guid.Parse(HttpContext.User.Claims.First().Value);
            shopDto.UserId = userId;
            _unitedRemoteService.DisLikeShops(shopDto);
        }
    }
}
