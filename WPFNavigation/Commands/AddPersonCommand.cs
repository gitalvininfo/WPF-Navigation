using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Services;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation.Commands
{
    public class AddPersonCommand : CommandBase
    {

        private readonly AddPersonViewModel _addPersonViewModel;
        private readonly INavigationService _navigationService;
        private readonly PeopleStore _peopleStore;

        public AddPersonCommand(AddPersonViewModel addPersonViewModel, PeopleStore peopleStore, INavigationService navigationService)
        {
            _addPersonViewModel = addPersonViewModel;
            _navigationService = navigationService;
            _peopleStore = peopleStore;
        }

        public override void Execute(object parameter)
        {
            string name = _addPersonViewModel.Name;
            _peopleStore.AddPerson(name);

            _navigationService.Navigate();
        }
    }
}
