﻿namespace HotelProject.WebUI.DTOs.BookingDTOs
{
    public class CreateBookingDTO
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int ChildCount { get; set; }
        public int AdultCount { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; }
        public string SpecialRequest { get; set; }
        public string Status { get; set; }
    }
}
