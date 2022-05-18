using DCTTask.API;
using DCTTask.Models;
using DCTTask.ViewModels;
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
            string url = "assets?limit=500";
            var da = new DataAccess<Data<Coin>>();
            var coins = await da.GetData(url);

            return coins.data;
        }

        public async Task<IEnumerable<Coin>> GetSearchedCoins(string name)
        {
            string url = $"assets?search={name}";
            var da = new DataAccess<Data<Coin>>();
            var coins = await da.GetData(url);

            return coins.data;
        }

    }
}
