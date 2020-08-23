using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FBC.Business.Services
{
    public interface IUserService
    {
        Task<bool> AuthenticateUser(string email, string password);
        string TestAnonymousToken(string token);
        Task<bool> TestSecret(string secret);
    }
}
