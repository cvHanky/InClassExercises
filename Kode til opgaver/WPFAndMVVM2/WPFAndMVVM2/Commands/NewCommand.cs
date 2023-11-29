using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFAndMVVM2.ViewModels;

namespace WPFAndMVVM2.Commands
{
    public class NewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            bool result = true;

            if (parameter is MainViewModel mvm)
                if (mvm.SelectedPerson == null)
                    result = false;

            return result;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                mvm.AddDefaultPerson();
            }
        }
    }
}
