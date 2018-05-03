using System;
using System.Threading.Tasks;
using PrismRefitTutorial.Models;
namespace PrismRefitTutorial.Services.Interfaces
{
    public interface IGithubService
    {
        Task<ApiResponse> GetUsers(string location);
    }
}
