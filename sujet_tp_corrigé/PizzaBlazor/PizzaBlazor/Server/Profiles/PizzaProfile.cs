using AutoMapper;
using PizzaBlazor.Data;
using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Server.Profiles
{
    public class PizzaProfile : Profile
    {
        public PizzaProfile()
        {
            CreateMap<Pizza, PizzaReadDTO>().ReverseMap();
            CreateMap<Pizza, PizzaWriteDTO>().ReverseMap();
        }
    }
}
