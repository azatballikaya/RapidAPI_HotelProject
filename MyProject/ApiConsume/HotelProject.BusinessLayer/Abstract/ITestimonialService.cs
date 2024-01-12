using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface ITestimonialService:IGenericService<Testimonial>
    {
        void Insert(Testimonial p);
        void Delete(Testimonial p);
        void Update(Testimonial p);
        List<Testimonial> GetList();
        Testimonial GetById(int id);
    }
}
