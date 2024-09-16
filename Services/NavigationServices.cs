using BetterNavigationServices.Core;
using BetterNavigationServices.Stores;
using System;

namespace BetterNavigationServices.Services
{
    public class NavigationServices<TViewModel> : INavigationService where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationServices(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViiewModel = _createViewModel();
        }
    }
}
