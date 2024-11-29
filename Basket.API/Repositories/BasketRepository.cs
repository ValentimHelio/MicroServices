using Basket.API.Entities;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ShoppingCart> UpdateBasked(ShoppingCart basked)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteBasket(string userName)
        {
            throw new System.NotImplementedException();
        }
    }
}
