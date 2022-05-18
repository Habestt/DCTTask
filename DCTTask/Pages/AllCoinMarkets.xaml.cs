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
    /// Логика взаимодействия для AllCoinMarkets.xaml
    /// </summary>
    public partial class AllCoinMarkets : Page
    {
        public AllCoinMarkets(string id)
        {
            InitializeComponent();
            GetData(id);
        }

        public async void GetData(string id)
        {
            MarketService marketService = new MarketService();
            var Markets = await marketService.GetCoinMarkets($"{id}");
            DataGrid1.ItemsSource = Markets;
        }
    }
}
