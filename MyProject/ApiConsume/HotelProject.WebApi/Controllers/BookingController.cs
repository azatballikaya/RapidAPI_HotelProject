using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            return Ok(_bookingService.GetList());
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.Insert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id) {
            
            var booking= _bookingService.GetById(id);
            _bookingService.Delete(booking);
            return Ok();
            
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.Update(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id) {
          var booking=  _bookingService.GetById(id);
            return Ok(booking);
        }
        [HttpGet("BookingStatusUpdateApproved/{id}")]
        public IActionResult BookingStatusUpdateApproved(int id)
        {
            _bookingService.BookingStatusChangeApproved(id);
            return Ok();
        }
    }
}
