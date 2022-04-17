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
    public class HomeViewModel : ViewModelBase
    {

        public string WelcomeMessage => "Welcome Alvin Yanson";
        public NavigationBarViewModel NavigationBarViewModel { get; }

        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel(
            NavigationBarViewModel navigationBarViewModel,
            NavigationService<LoginViewModel> loginNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;

            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
