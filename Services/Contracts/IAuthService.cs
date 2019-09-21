using System.Threading.Tasks;

namespace Projekt.Services.Contracts
{
    public interface IAuthService : IAppService
    {
        Task<string> SignInAsync(string email, string password);
        Task<string> RegisterAsync(string email, string password, string card, string firstName, string lastName);
    }
}