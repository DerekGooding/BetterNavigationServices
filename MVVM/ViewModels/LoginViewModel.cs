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

namespace BetterNavigationServices.MVVM.ViewModesl
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand HomeCommand { get; }
        public LoginViewModel(NavigationServicesFactory navigationServicesFactory)
        {
            var HomeViewModelNavigationService = navigationServicesFactory.CreateHomeNavigationService();
            HomeCommand = new MoveToHomeViewCommand(HomeViewModelNavigationService);
        }
    }
}
