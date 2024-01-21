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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About p)
        {
            _aboutDal.Delete(p);
        }

        public About GetById(int id)
        {
          return  _aboutDal.GetById(id);
        }

        public List<About> GetList()
        {
          return  _aboutDal.GetList();
        }

        public void Insert(About p)
        {
           _aboutDal.Insert(p);
        }

        public void Update(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
