using BetterNavigationServices.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
