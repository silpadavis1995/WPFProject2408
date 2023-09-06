using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFTemplate.Helpers;
using WPFTemplate.Interfaces;

namespace WPFTemplate.ViewModels
{
    class ExitViewModel : BaseViewModel
    {
        public ExitViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }
       
     
        public ICommand ExitAction
        {
            get { return new RelayCommand(Exitaction); }
        }
        private void Exitaction()
        {
            Application.Current.Shutdown();
        }

    }
}