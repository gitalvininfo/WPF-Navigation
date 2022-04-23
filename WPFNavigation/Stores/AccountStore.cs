using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Models;

namespace WPFNavigation.Stores
{
    public class AccountStore
    {
        private Account _currentAccount;
        public event Action CurrentAccountChanged;

        public Account CurrentAccount 
        {
            get => _currentAccount;
            set
            {
                _currentAccount = value;
                CurrentAccountChanged?.Invoke();

            }
        }

        public bool IsLoggedIn => CurrentAccount != null;



        public void Logout()
        {
            CurrentAccount = null;
        }

    }
}
