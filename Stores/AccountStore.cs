using BetterNavigationServices.MVVM.Models;

namespace BetterNavigationServices.Stores
{
    public class AccountStore
    {
		private Account _currentAccount;
		public Account CurrentAccount
		{
			get => _currentAccount;
			set
			{
				Account _currentAccount = value;
			}
		}

		public bool IsLoggedIn => _currentAccount != null;
	}
}
