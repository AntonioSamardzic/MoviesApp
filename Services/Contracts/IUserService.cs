using System.Threading.Tasks;
using Projekt.Models;

namespace Projekt.Core.Services.Contracts
{
    public interface IUserService
    {
        Task<AuthUser> getByEmailAsync(string email);
    }
}