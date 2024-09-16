namespace BetterNavigationServices.Commands;

public class MoveToHomeViewCommand(INavigationService navigationService) : RelayCommand(navigationService.Navigate);
