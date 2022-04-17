using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Models;
using WPFNavigation.Services;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        private readonly AccountStore _accountStore;

        public NavigationBarViewModel NavigationBarViewModel { get; }

        public string Username => _accountStore.CurrentAccount?.Username;
        public string Email => _accountStore.CurrentAccount?.Email; 
        public ICommand NavigateHomeCommand { get; }


        public AccountViewModel(
            NavigationBarViewModel navigationBarViewModel,
            AccountStore accountStore, NavigationService<HomeViewModel> homeNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;

            _accountStore = accountStore;


            NavigateHomeCommand =
                new NavigateCommand<HomeViewModel>(homeNavigationService);

        }

    }
}
