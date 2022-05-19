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
        private const int limit = 20;
        public int OffSet { get; set; }
        public int PageCounter { get; set; } = 1;

        public AllCoins()
        {
            InitializeComponent();
            GetData(OffSet);
            PrevBtn.IsEnabled = false;
        }

        public AllCoins(IEnumerable<Coin> coins)
        {
            InitializeComponent();
            DataGrid1.ItemsSource = coins;
            Row3.Height = new GridLength(0);
        }

        private async void GetData(int offSet)
        {            
            CoinService coinService = new CoinService();
            var Coins = await coinService.GetAllCoins(limit, offSet);
            if (Coins.Any(x => Coins.Count() != limit)) NextBtn.IsEnabled = false;
            DataGrid1.ItemsSource = Coins;
            PageNumberLbl.Content = $"{PageCounter}";
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
            Row3.Height = new GridLength(0);
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchBtn_Click(this, null);
            }
        }

        private async void NextBtn_Click(object sender, RoutedEventArgs e)
        { 
            PrevBtn.IsEnabled = true;
            OffSet += 20;
            PageCounter++;
            GetData(OffSet);            
        }

        private async void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PageCounter == 2) PrevBtn.IsEnabled = false;
            NextBtn.IsEnabled = true;
            OffSet -= 20;
            PageCounter--;
            GetData(OffSet);            
        }
    }
}
