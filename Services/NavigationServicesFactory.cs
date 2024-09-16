using BetterNavigationServices.MVVM.ViewModels;
using BetterNavigationServices.Stores;

namespace BetterNavigationServices.Services;

public class NavigationServicesFactory(AccountStore accountStore, NavigationStore navigationStore)
{
    private readonly AccountStore _accountStore = accountStore;
    private readonly NavigationStore _navigationStore = navigationStore;

    public INavigationService CreateHomeNavigationService() => new NavigationServices<HomeViewModel>(_navigationStore, () => new HomeViewModel(this));
    public INavigationService CreateLoginNavigationService() => new NavigationServices<LoginViewModel>(_navigationStore, () => new LoginViewModel(this));
}
