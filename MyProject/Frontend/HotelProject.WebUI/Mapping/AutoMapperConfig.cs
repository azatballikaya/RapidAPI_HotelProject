using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AboutDTOs;
using HotelProject.WebUI.DTOs.BookingDTOs;
using HotelProject.WebUI.DTOs.LoginDTOs;
using HotelProject.WebUI.DTOs.RegisterDTOs;
using HotelProject.WebUI.DTOs.ServiceDTOs;
using HotelProject.WebUI.DTOs.StaffDTOs;
using HotelProject.WebUI.DTOs.SubscribeDTOs;

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

            CreateMap<ResultAboutDTO,About>().ReverseMap();
            CreateMap<UpdateAboutDTO,About>().ReverseMap();

            CreateMap<ResultStaffDTO,Staff>().ReverseMap();

            CreateMap<CreateSubscribeDTO,Subscribe>().ReverseMap();

            CreateMap<CreateBookingDTO,Booking>().ReverseMap(); 
            CreateMap<ResultBookingDTO,Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO,Booking>().ReverseMap();   
        }
    }
}
