using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DTOLayer.DTOs.RoomDTOs;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebApi.Mapping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        AutoMapperConfig autoMapperConfig=new AutoMapperConfig();
        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values =  _roomService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(RoomAddDTO roomAddDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var values = _mapper.Map<Room>(roomAddDTO);
                 _roomService.Insert(values);
                
                    return Ok();
                
            }
        }
        [HttpPut]
        public IActionResult UpdateRoom (RoomUpdateDTO roomUpdateDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var values =_mapper.Map<Room>(roomUpdateDTO);
                _roomService.Update(values);
                return Ok();
            }
        }
    }
}
