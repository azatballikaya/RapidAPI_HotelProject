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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _TestimonialDal;

        public TestimonialManager(ITestimonialDal TestimonialDal)
        {
            _TestimonialDal = TestimonialDal;
        }

        public void Delete(Testimonial p)
        {
            _TestimonialDal.Delete(p); 
        }

        public Testimonial GetById(int id)
        {
           return _TestimonialDal.GetById(id);
        }

        public List<Testimonial> GetList()
        {
            return _TestimonialDal.GetList();
        }

        public void Insert(Testimonial p)
        {
            _TestimonialDal.Insert(p);
        }

        public void Update(Testimonial p)
        {
            _TestimonialDal.Update(p);
        }
    }
}
