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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _SubscribeDal;

        public SubscribeManager(ISubscribeDal SubscribeDal)
        {
            _SubscribeDal = SubscribeDal;
        }

        public void Delete(Subscribe p)
        {
            _SubscribeDal.Delete(p); 
        }

        public Subscribe GetById(int id)
        {
           return _SubscribeDal.GetById(id);
        }

        public List<Subscribe> GetList()
        {
            return _SubscribeDal.GetList();
        }

        public void Insert(Subscribe p)
        {
            _SubscribeDal.Insert(p);
        }

        public void Update(Subscribe p)
        {
            _SubscribeDal.Update(p);
        }
    }
}
