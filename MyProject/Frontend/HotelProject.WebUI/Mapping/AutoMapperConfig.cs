using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.LoginDTOs;
using HotelProject.WebUI.DTOs.RegisterDTOs;
using HotelProject.WebUI.DTOs.ServiceDTOs;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();

            CreateMap<CreateRegisterDTO,AppUser>().ReverseMap();
            CreateMap<LoginUserDTO,AppUser>().ReverseMap();
        }
    }
}
