using AutoMapper;
using DataAccess.Models;
using Domain.DTOs;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, UserDTO>();
        CreateMap<UserDTO, User>();
        CreateMap<User, UserCreateOrUpdateDTO>();
        CreateMap<UserCreateOrUpdateDTO, User>();
    }
    
}