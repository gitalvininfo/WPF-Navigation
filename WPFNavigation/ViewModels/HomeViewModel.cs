using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        public string WelcomeMessage => "Welcome Alvin Yanson";

        public ICommand NavigateAccountCommand { get; }


        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
        }
    }
}
