using BetterNavigationServices.Commands;
using BetterNavigationServices.Core;
using BetterNavigationServices.Services;
using System.Windows.Input;

namespace BetterNavigationServices.Commands
{
    public class MoveToLoginViewCommand : RelayCommand
    {
        public MoveToLoginViewCommand(INavigationService navigationService)
            : base(() => navigationService.Navigate())
        {
        }
    }
}
