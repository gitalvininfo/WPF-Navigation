using WPFNavigation.ViewModels;

namespace WPFNavigation.Services
{
    public interface INavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        void Navigate();
    }
}