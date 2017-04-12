using AuthDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Repositories
{
    public interface IUsersRepository
    {
        Task<ApplicationUser> GetById(string id);
        Task<ApplicationUser> GetByName(string name);
        Task Add(ApplicationUser user);
        Task<bool> Update(ApplicationUser user);
        Task<bool> Delete(ApplicationUser user);
    }
}
