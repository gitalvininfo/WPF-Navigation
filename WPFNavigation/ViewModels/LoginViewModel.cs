﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Services;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }


        public LoginViewModel(NavigationStore navigationStore)
        {
            LoginCommand = new LoginCommand(this, new NavigationService<AccountViewModel>(
                    navigationStore, () => new AccountViewModel(navigationStore)));
        }
    }
}
