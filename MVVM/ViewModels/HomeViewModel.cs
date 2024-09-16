using BetterNavigationServices.Commands;
using BetterNavigationServices.Core;
using BetterNavigationServices.Services;
using BetterNavigationServices.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace BetterNavigationServices.MVVM.ViewModesl
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand LoginCommand { get; }
        public HomeViewModel(NavigationServicesFactory navigationServicesFactory)
        {
            var LoginViewModelNavigationService = navigationServicesFactory.CreateLoginNavigationService();

            LoginCommand =  new MoveToLoginViewCommand(LoginViewModelNavigationService);

        }
    }
}
