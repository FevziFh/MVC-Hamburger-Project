using AutoMapper;
using Hamburger_DATA.Concrete;
using Hamburger_Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //CreateMap<SauceDTO,Sauce>().ReverseMap();
            CreateMap<MenuCreateDTO, Menu>().ReverseMap();
            CreateMap<MenuUpdateDTO, Menu>().ReverseMap();
            //CreateMap<MenuDeleteDTOs, Menu>().ReverseMap();

            CreateMap<SauceCreateDTO, Sauce>().ReverseMap();
            CreateMap<SauceUpdateDTO, Sauce>().ReverseMap();
        }
    }
}
