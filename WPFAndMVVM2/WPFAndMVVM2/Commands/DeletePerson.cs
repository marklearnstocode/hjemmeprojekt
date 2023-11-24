using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFAndMVVM2.ViewModels;

namespace WPFAndMVVM2.Commands
{
    internal class DeletePerson : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            bool result = true;
            if (parameter is MainViewModel mvm)
            {
                if (mvm.SelectedPerson == null)
                {
                    result = false;
                }
            }
            //else
            //    throw new ArgumentException("Du skal vælge en person, før du kan slette");

            return result;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                mvm.DeleteSelectedPerson();
            }
        }
    }
}
