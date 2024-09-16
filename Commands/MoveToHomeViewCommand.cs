namespace BetterNavigationServices.Commands;

public class MoveToLoginViewCommand(INavigationService navigationService) : RelayCommand(() => navigationService.Navigate())
{
}
