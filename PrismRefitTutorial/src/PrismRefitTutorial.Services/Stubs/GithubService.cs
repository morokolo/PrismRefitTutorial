using System;
using System.Threading.Tasks;
using PrismRefitTutorial.Models;
using PrismRefitTutorial.Services.Interfaces;
using System.Collections.Generic;

namespace PrismRefitTutorial.Services.Stubs
{
    public class GithubService : IGithubService
    {
        public Task<ApiResponse> GetUsers(string location)
        {
            return Task.FromResult(new ApiResponse
            {
                incompleteResults = false,
                totalCount = 1,
                items = new List<User>()
                {
                    new User()
                    {
                        userName = "test",
                    }
                }
            });
        }
    }
}


