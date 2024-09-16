using BetterNavigationServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterNavigationServices.Stores
{
    public class NavigationStore
    {

		public event Action CurrentViewModelChanged;

		private ViewModelBase _currentViewModel;
		public ViewModelBase CurrentViiewModel
		{
			get
			{
				return _currentViewModel;
			}
			set
			{
				_currentViewModel = value;
                OnCurrentViewModelChanged();
			}
		}

        private void OnCurrentViewModelChanged()
        {
			CurrentViewModelChanged?.Invoke();
        }
    }
}
