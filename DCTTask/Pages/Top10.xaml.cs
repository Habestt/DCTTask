using DCTTask.Models;
using DCTTask.Services;
using DCTTask.ViewModels;
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
    /// Логика взаимодействия для Top10.xaml
    /// </summary>
    public partial class Top10 : Page
    {
        public Top10()
        {
            InitializeComponent();
            GetData();
        }

        public async void GetData()
        {
            MarketService marketService = new MarketService();            
            var Pairs = await marketService.GetTop10Coins("binance");
            DataGrid1.ItemsSource = Pairs;
        }

        private async void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            CoinService coinService = new CoinService();
            var data = await coinService.GetSearchedCoins(SearchTxt.Text);
            NavigationService.Navigate(new AllCoins(data));
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
