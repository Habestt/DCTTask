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
            CoinService coinService = new CoinService();            
            var Coins = await coinService.GetTop10();
            DataGrid1.ItemsSource = Coins;
        }
    }
}
