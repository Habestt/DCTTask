using DCTTask.Pages;
using DCTTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DCTTask.Commands
{
    internal class UpdatePageCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdatePageCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            if (parameter != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Execute(object? parameter)
        {
            if (parameter.ToString() == "AllCoins")
            {
                viewModel.CurrentPage = new AllCoins();
            }
            else if (parameter.ToString() == "Top10")
            {
                viewModel.CurrentPage = new Top10();
            }

        }
    }
}
