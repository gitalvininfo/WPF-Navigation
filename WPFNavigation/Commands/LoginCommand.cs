using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFNavigation.Models;
using WPFNavigation.Services;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly AccountStore _accountStore;
        private readonly NavigationService<AccountViewModel> _navigationService;

        public LoginCommand(
            LoginViewModel loginViewModel, 
            AccountStore accountStore, 
            NavigationService<AccountViewModel> navigationService)
        {
            _loginViewModel = loginViewModel;
            _accountStore = accountStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {

            Account account = new Account()
            {
                Email = $"{_loginViewModel.Username}@test.com",
                Username = _loginViewModel.Username
            };

            _accountStore.CurrentAccount = account;

            _navigationService.Navigate();
        }
    }
}
