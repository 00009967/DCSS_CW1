using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.src.users.DTO;
using UsersApi.src.users.Models;

namespace UsersApi.src.Global
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}
