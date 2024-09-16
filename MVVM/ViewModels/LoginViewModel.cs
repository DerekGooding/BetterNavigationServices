using BetterNavigationServices.Commands;
using BetterNavigationServices.Core;
using BetterNavigationServices.Services;
using System.Windows.Input;

namespace BetterNavigationServices.MVVM.ViewModels;

public class LoginViewModel : ViewModelBase
{
    public ICommand HomeCommand { get; }
    public LoginViewModel(NavigationServicesFactory navigationServicesFactory)
    {
        var HomeViewModelNavigationService = navigationServicesFactory.CreateHomeNavigationService();
        HomeCommand = new MoveToHomeViewCommand(HomeViewModelNavigationService);
    }
}
