using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RepositoryInterfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAsync();
        Task<User?> GetAsync(string id);
        Task CreateAsync(User newUser);
        Task UpdateAsync(string id, User updatedUser);
        Task RemoveAsync(string id);

    }
}
