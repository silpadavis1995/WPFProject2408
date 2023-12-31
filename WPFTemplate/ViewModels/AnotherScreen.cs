﻿using WPFTemplate.Helpers;
using WPFTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTemplate.ViewModels
{
    class AnotherScreen : BaseViewModel
    {
        public AnotherScreen(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        //public ICommand GoToEixt
        //{
        //    get { return new RelayCommand(PopToMainMenu); }
        //}

        //private void PopToMainMenu()
        //{
        //    PopViewModel();
        //}

        public ICommand GoToEixt
        {
            get { return new RelayCommand(LoadExitScreen); }
        }

        private void LoadExitScreen()
        {
            PushViewModel(new ExitViewModel(ViewModelChanger));
        }
    }
}
