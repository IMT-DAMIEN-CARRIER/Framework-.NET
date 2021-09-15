using AutoMapper;
using BlogBlazor.Data.Model;
using BlogBlazor.Shared.Model.Author;

namespace BlogBlazor.Server.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorReadDTO>().ReverseMap();
            CreateMap<Author, AuthorWriteDTO>().ReverseMap();
            CreateMap<Author, AuthorLoginReadDTO>().ReverseMap();
        }
    }
}