using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Shared.DTO;
using Blog.Data.Models;

namespace Blog.Server.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorWriteDTO>().ReverseMap();
            CreateMap<Author, AuthorReadDTO>().ReverseMap();
            CreateMap<Author, AuthorLoginDTO>().ReverseMap();
        }
    }
}
