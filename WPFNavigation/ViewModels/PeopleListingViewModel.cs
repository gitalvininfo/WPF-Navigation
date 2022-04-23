using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Services;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class PeopleListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<PersonViewModel> _people;
        private readonly PeopleStore _peopleStore;

        public IEnumerable<PersonViewModel> People => _people;

        public ICommand AddPersonCommand { get; }

        public PeopleListingViewModel(PeopleStore peopleStore, INavigationService addPersonNavigationService)
        {
            _peopleStore = peopleStore;


            AddPersonCommand = new NavigateCommand(addPersonNavigationService);

            _people = new ObservableCollection<PersonViewModel>();

            _people.Add(new PersonViewModel("Test 1"));
            _people.Add(new PersonViewModel("Test 2"));
            _people.Add(new PersonViewModel("Test 3"));

            _peopleStore.PersonAdded += OnPersonAdded;

        }

        private void OnPersonAdded(string name)
        {
            _people.Add(new PersonViewModel(name));
        }
    }
}
