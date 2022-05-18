using DCTTask.Commands;
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
        public ICommand UpdatePage { get; set; }
        public ICommand Top10Btn { get; set; }

        private Page _currentPage;
        public Page CurrentPage {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            } 
        }
        
        
        public MainViewModel()
        {
            CurrentPage = new Top10();
            UpdatePage = new UpdatePageCommand(this);
        }        
    }
}
