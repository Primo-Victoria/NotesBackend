﻿using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password);
        Task<UserInformationBlo> AuthWithPhone(string numberPrefix, string number, string password);
        Task<UserInformationBlo> AuthWithEmail(string email, string password);
        Task<UserInformationBlo> AuthWithLogin(string login, string password);
        Task<UserInformationBlo> Get(int userId);
        Task<UserInformationBlo> Update(string numberPrefix, string number, string password, UserUpdateBlo userUpdateBlo);
        Task<bool> DoesExist(string numberPrefix, string number);
    }
}
