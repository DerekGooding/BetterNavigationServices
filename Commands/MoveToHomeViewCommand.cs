using BetterNavigationServices.Core;

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
