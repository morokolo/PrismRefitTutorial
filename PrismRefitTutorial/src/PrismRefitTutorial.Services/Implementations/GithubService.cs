using System;
using PrismRefitTutorial.Models;
using PrismRefitTutorial.Services.Interfaces;
using Refit;
using PrismRefitTutorial.Services.API;
using System.Threading.Tasks;

namespace PrismRefitTutorial.Services.Implementations
{
    public class GithubService : IGithubService
    {
        public async Task<ApiResponse> GetUsers(string location)
        {
            try
            {
                var gitApi = RestService.For<IGithubApi>("https://api.github.com");
                var result = await gitApi.GetUsers(location);

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
