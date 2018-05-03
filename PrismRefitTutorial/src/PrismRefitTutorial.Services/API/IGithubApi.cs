using System;
using System.Threading.Tasks;
using PrismRefitTutorial.Models;
using Refit;

namespace PrismRefitTutorial.Services.API
{
    [Headers("User-Agent: mytestapp")]
    public interface IGithubApi
    {
        [Get("/search/users?q=location:{location}")]
        Task<ApiResponse> GetUsers(string location);
    }
}
