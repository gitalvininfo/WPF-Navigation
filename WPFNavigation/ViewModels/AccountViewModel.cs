using System;
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
    public class AccountViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Account Page";
        public ICommand NavigateHomeCommand { get; }


        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand =
                new NavigateCommand<HomeViewModel>(
                new NavigationService<HomeViewModel>(
                    navigationStore, () => new HomeViewModel(navigationStore)));
        }

    }
}
