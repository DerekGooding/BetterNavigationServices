using BetterNavigationServices.Commands;
using BetterNavigationServices.Core;
using BetterNavigationServices.Services;
using System.Windows.Input;

namespace BetterNavigationServices.Commands
{
    public class MoveToHomeViewCommand : RelayCommand
    {
        public MoveToHomeViewCommand(INavigationService navigationService)
            : base(() => navigationService.Navigate())
        {
        }
    }
}
