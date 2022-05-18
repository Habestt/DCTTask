using DCTTask.Models;
using DCTTask.Pages;
using DCTTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DCTTask.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public ICommand AllCoinsBtn { get; }
        public ICommand TrendingBtn { get; }

        public Page CurrentPage { get; set; }
        
        
        public MainViewModel()
        {            
            CurrentPage = new Top10();
        }        
    }
}
