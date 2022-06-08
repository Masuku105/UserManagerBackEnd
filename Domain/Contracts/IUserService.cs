

using Domain.DTOs;

namespace Domain.Contracts
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAsync();
        Task<UserDTO?> GetAsync(string id);
        Task CreateAsync(UserDTO newUser);
        Task UpdateAsync(string id, UserDTO updatedUser);
        Task RemoveAsync(string id);
    }
}
