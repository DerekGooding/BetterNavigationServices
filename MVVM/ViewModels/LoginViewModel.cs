﻿using BetterNavigationServices.Commands;
using BetterNavigationServices.Services;
using System.Windows.Input;

namespace BetterNavigationServices.MVVM.ViewModels;

public class LoginViewModel : ViewModelBase
{
    public ICommand HomeCommand { get; }

    public LoginViewModel(NavigationServicesFactory navigationServicesFactory)
    {
        INavigationService HomeViewModelNavigationService = navigationServicesFactory.CreateHomeNavigationService();

        HomeCommand = new MoveToHomeViewCommand(HomeViewModelNavigationService);
    }
}
