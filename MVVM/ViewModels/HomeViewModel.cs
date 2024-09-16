using BetterNavigationServices.Commands;
using BetterNavigationServices.Services;
using System.Windows.Input;

namespace BetterNavigationServices.MVVM.ViewModels;

public class HomeViewModel : ViewModelBase
{
    public ICommand LoginCommand { get; }

    public HomeViewModel(NavigationServicesFactory navigationServicesFactory)
    {
        INavigationService LoginViewModelNavigationService = navigationServicesFactory.CreateLoginNavigationService();

        LoginCommand = new MoveToLoginViewCommand(LoginViewModelNavigationService);
    }
}
