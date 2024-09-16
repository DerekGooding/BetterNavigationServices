namespace BetterNavigationServices.Commands;

public class MoveToHomeViewCommand : RelayCommand
{
    public MoveToHomeViewCommand(INavigationService navigationService)
        : base(() => navigationService.Navigate())
    {
    }
}
