﻿using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AwesomeShop.BusinessLogic.Accounts.Requests;

namespace AwesomeShop.BusinessLogic.Accounts.Interfaces
{
    public interface IUserClaimsFactory
    {
        Task<List<Claim>> GetClaimsAsync(User user);
    }
}