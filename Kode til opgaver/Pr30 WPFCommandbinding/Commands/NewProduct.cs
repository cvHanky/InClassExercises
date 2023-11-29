using Pr30_WPFCommandbinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pr30_WPFCommandbinding.Commands
{
    public class NewProduct : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            bool result = true;

            if (parameter is MainViewModel mvm)
                if (mvm.SelectedProduct == null)
                    result = false;

            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            {

            }
        }
    }
}
