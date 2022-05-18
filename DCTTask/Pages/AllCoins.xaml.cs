using DCTTask.Models;
using DCTTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DCTTask.Pages
{
    /// <summary>
    /// Логика взаимодействия для AllCoins.xaml
    /// </summary>
    public partial class AllCoins : Page
    {
        public AllCoins()
        {
            InitializeComponent();
            GetData();
        }

        public AllCoins(IEnumerable<Coin> coins)
        {
            InitializeComponent();
            DataGrid1.ItemsSource = coins;
        }

        public async void GetData()
        {
            CoinService coinService = new CoinService();
            var Coins = await coinService.GetAllCoins();
            DataGrid1.ItemsSource = Coins;
        }
        private void GetMarketsBtn_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            Coin? coin = button.DataContext as Coin;
            string id = coin.id;
            NavigationService.Navigate(new AllCoinMarkets(id));
        }

        private async void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            CoinService coinService = new CoinService();
            var data = await coinService.GetSearchedCoins(SearchTxt.Text);
            DataGrid1.ItemsSource = data;
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchBtn_Click(this, null);
            }
        }
    }
}
