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

        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel(
            INavigationService loginNavigationService)
        {

            NavigateLoginCommand = new NavigateCommand(loginNavigationService);
        }
    }
}
