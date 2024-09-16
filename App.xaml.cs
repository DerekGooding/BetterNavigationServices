using BetterNavigationServices.MVVM.ViewModesl;
using BetterNavigationServices.Services;
using BetterNavigationServices.Stores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BetterNavigationServices
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly AccountStore _accountStore;
        private readonly NavigationServicesFactory _navigationServicesFactory;

        public App()
        {
            _navigationStore = new NavigationStore();
            _accountStore = new AccountStore();
            _navigationServicesFactory = new NavigationServicesFactory(_accountStore, _navigationStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            var homeNavigationService = _navigationServicesFactory.CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore, _navigationServicesFactory)
            };
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
