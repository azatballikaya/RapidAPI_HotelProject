using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal:GenericRepository<Booking>,IBookingDal
    {
        public EfBookingDal(Context context):base(context) 
        {
            
        }

        public void BookingStatusChangeApproved(int id)
        {
            Context context = new Context();
            var booking= context.Bookings.Find(id);
            booking.Status = "Onaylandı";
            var entity = context.Entry(booking);
            entity.State=EntityState.Modified;
            context.SaveChanges();
        }
    }
}
