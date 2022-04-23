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


        public string Username => _accountStore.CurrentAccount?.Username;
        public string Email => _accountStore.CurrentAccount?.Email; 
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(
            AccountStore accountStore, INavigationService<HomeViewModel> homeNavigationService)
        {

            _accountStore = accountStore;


            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);

            /* subscribes to changes in account store event named as CurrentAccountChanged */
            _accountStore.CurrentAccountChanged += OnCurrentAccountChanged;

        }


        ~AccountViewModel()
        {

        }

        /* after click of logout, clear the property username and email,
         * this is the listener for logout when click 
         after logout what do you want to do to properties */
        private void OnCurrentAccountChanged()
        {
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(Email));
        }

        public override void Dispose()
        {
            _accountStore.CurrentAccountChanged -= OnCurrentAccountChanged;

            base.Dispose();
        }
    }
}
