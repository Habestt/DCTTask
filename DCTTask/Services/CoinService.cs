using DCTTask.API;
using DCTTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCTTask.Services
{
    internal class CoinService
    {
        public async Task<IEnumerable<Coin>> GetAllCoins()
        {
            string url = "coins/markets?vs_currency=usd";
            var da = new DataAccess<Coin>();
            var coins = await da.GetData(url);

            return coins;
        }

        public async Task<IEnumerable<Coin>> GetTrendingCoins()
        {
            string url = "search/trending";
            var da = new DataAccess<Coin>();
            var coins = await da.GetData(url);

            return coins;
        }

        public async Task<IEnumerable<Coin>> GetCoin(string id)
        {
            string url = $"search/coins/{id}";
            var da = new DataAccess<Coin>();
            var coin = await da.GetData(url);

            return coin;
        }

    }
}
