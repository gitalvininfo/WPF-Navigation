using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFNavigation.Services;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly NavigationService<AccountViewModel> _navigationService;

        public LoginCommand(LoginViewModel loginViewModel, NavigationService<AccountViewModel> navigationService)
        {
            _loginViewModel = loginViewModel;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            MessageBox.Show($"Logging in {_loginViewModel.Username}...");
            _navigationService.Navigate();
        }
    }
}
