using BetterNavigationServices.MVVM.Models;

namespace BetterNavigationServices.Stores;

public class AccountStore
{
    public Account? CurrentAccount { get; set; }

    public bool IsLoggedIn => CurrentAccount != null;
}
