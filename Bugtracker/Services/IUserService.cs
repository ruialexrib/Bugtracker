﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bugtracker.Services
{
    public interface IUserService
    {
        Task<List<IdentityUser>> GetUsersAsync();

        Task<IdentityUser> GetUserByUserIdAsync(string userId);

        Task<bool> AssignUserRoleAsync(string userId, string rolename);
    }
}
