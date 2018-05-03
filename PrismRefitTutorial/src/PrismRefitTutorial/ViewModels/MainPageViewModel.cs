using System;
using System.Linq;
using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using PrismRefitTutorial.Services.Interfaces;
using System.Diagnostics;
using System.Collections.Generic;
using PrismRefitTutorial.Models;

namespace PrismRefitTutorial.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IGithubService _githubService;

        public ApiResponse GitHubUsers { get; set; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService,
                                 IDeviceService deviceService, IGithubService githubService)
            : base(navigationService, pageDialogService, deviceService)
        {
            Title = "Main Page";
            _githubService = githubService;
        }

        private async void GetUsers()
        {
            try
            {
                this.GitHubUsers = await _githubService.GetUsers("johannesburg");


            }
            catch (Exception e)
            {
                await _pageDialogService.DisplayAlertAsync("Error", e.Message, "OK");
            }
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);

            GetUsers();
        }

    }
}
