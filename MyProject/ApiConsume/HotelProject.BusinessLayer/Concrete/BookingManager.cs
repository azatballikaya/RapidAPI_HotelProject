using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void BookingStatusChangeApproved(int id)
        {
            _bookingDal.BookingStatusChangeApproved(id);
        }

        public void Delete(Booking p)
        {
           _bookingDal.Delete(p);
        }

        public Booking GetById(int id)
        {
           return _bookingDal.GetById(id);
        }

        public List<Booking> GetList()
        {
            return _bookingDal.GetList();
        }

        public void Insert(Booking p)
        {
            _bookingDal.Insert(p);
        }

        public void Update(Booking p)
        {
            _bookingDal.Update(p);
        }
    }
}
