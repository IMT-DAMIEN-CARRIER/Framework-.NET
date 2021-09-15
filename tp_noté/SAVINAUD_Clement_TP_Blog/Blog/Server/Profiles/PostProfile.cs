using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Shared.DTO;
using Blog.Data.Models;

namespace Blog.Server.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostWriteDTO>().ReverseMap();
            CreateMap<Post, PostReadDTO>().ReverseMap();
        }
    }
}
