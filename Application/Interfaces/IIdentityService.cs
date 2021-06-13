using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Application.Models;
using Inventory.Domain.Model;

namespace Inventory.Application.Interfaces
{
    public interface IdentityService
    {
        Task<(Result result, string id)> CreateUser(string username, string password, string email);
        Task<Result> DelteUser(string id);
        Task<Result> UpdateUser(string id, string username, string email);
        Task<bool> RequestPasswordChange(string id);
        Task<Result> ConfirmPasswordChange(string username, string token);
        Task<string> GetUserEmailById(string id);
        Task<string> GetUserNameById(string id);
        Task<bool> IsInRole(string id, string role);
        Task<Result> Authorize(string username, string password);
    }
}