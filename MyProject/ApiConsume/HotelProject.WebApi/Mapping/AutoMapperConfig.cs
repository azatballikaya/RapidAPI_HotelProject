using AutoMapper;
using HotelProject.DTOLayer.DTOs.RoomDTOs;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDTO, Room>();
            CreateMap<Room,RoomAddDTO>();

            CreateMap<RoomUpdateDTO, Room>().ReverseMap();
        }
    }
}
