using AutoMapper;
using BlogBlazor.Data.Model;
using BlogBlazor.Shared.Model.Category;

namespace BlogBlazor.Server.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryReadDTO>().ReverseMap();
            CreateMap<Category, CategoryWriteDTO>().ReverseMap();
        }
    }
}