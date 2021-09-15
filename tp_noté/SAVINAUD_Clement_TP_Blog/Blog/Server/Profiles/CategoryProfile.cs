using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Shared.DTO;
using Blog.Data.Models;

namespace Blog.Server.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryWriteDTO>().ReverseMap();
            CreateMap<Category, CategoryReadDTO>().ReverseMap();
        }
    }
}
