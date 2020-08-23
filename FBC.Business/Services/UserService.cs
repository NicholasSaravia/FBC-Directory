using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FBC.Business.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserService(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<bool> AuthenticateUser(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
