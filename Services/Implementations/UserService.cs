using System.Linq;
using System.Threading.Tasks;
using Projekt.Core.Services.Contracts;
using Projekt.Models;
using Microsoft.EntityFrameworkCore;

namespace Projekt.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ProjektContext Context;

        public UserService(ProjektContext context)
        {
            Context = context;
        }

        public async Task<AuthUser> getByEmailAsync(string email)
        {
            return await Context.Users
                .Where(u => u.Email == email)
                .Select(u => new AuthUser {
                    Id = u.Id,
                    Email = u.Email
                }).FirstAsync();
        }
    }
}