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
        }

        public async void GetData()
        {
            CoinService coinService = new CoinService();
            var Coins = await coinService.GetAllCoins();
            DataGrid1.ItemsSource = Coins;
        }
    }
}
