using BetterNavigationServices.Commands;
using BetterNavigationServices.Core;
using BetterNavigationServices.Services;
using System.Windows.Input;

namespace BetterNavigationServices.MVVM.ViewModesl;

public class HomeViewModel : ViewModelBase
{
    public ICommand LoginCommand { get; }
    public HomeViewModel(NavigationServicesFactory navigationServicesFactory)
    {
        var LoginViewModelNavigationService = navigationServicesFactory.CreateLoginNavigationService();

        LoginCommand =  new MoveToLoginViewCommand(LoginViewModelNavigationService);
    }
}
