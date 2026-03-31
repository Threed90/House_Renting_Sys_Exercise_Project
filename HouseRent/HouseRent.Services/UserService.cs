using HouseRent.Data.DTO;
using HouseRent.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseRent.Services
{
    public class UserService : IUserService
    { 
        public UserService()
        {
            
        }
        public Task Login(LoginViewModel login)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public Task PromoteToAgent(string userId)
        {
            throw new NotImplementedException();
        }

        public Task Register(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task SetUserInfo(UserInfoViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
