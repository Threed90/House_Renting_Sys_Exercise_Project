using HouseRent.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseRent.Services.Interfaces
{
    public interface IUserService
    {
        public Task Login(LoginViewModel login);

        public Task Register (RegisterViewModel model);

        public Task SetUserInfo(UserInfoViewModel model);

        public Task PromoteToAgent(string userId);
        public Task Logout();
    }
}
