using AutoMapper;
using DataAccess.Models;
using DataAccess.RepositoryInterfaces;
using Domain.Contracts;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _objectMapper;

        public UserService(IUserRepository userRepository, IMapper objectMapper)
        {
            _userRepository = userRepository;
            _objectMapper = objectMapper;
        }
        public async Task<List<UserDTO>> GetAsync()
        {
            var users = await _userRepository.GetAsync();
            return _objectMapper.Map<List<UserDTO>>(users); 
        }

        public async Task<UserDTO?> GetAsync(string id)
        {
            var user = await _userRepository.GetAsync(id);
            return _objectMapper.Map<UserDTO>(user);
        }
        public async Task CreateAsync(UserDTO newUser)
        {
            await _userRepository.CreateAsync(_objectMapper.Map<User>(newUser));
        }
        public async Task UpdateAsync(string id, UserDTO updatedUser)
        {
            await _userRepository.UpdateAsync(id,_objectMapper.Map<User>(updatedUser));
        }
        public async Task RemoveAsync(string id)
        {
           await _userRepository.RemoveAsync(id);
        }

       
    }
}
