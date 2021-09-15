using AutoMapper;
using BlogBlazor.Data.Model;
using BlogBlazor.Shared.Model.Post;

namespace BlogBlazor.Server.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostReadDTO>().ReverseMap();
            CreateMap<Post, PostWriteDTO>().ReverseMap();
        }
    }
}