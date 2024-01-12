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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _ServiceDal;

        public ServiceManager(IServiceDal ServiceDal)
        {
            _ServiceDal = ServiceDal;
        }

        public void Delete(Service p)
        {
            _ServiceDal.Delete(p); 
        }

        public Service GetById(int id)
        {
           return _ServiceDal.GetById(id);
        }

        public List<Service> GetList()
        {
            return _ServiceDal.GetList();
        }

        public void Insert(Service p)
        {
            _ServiceDal.Insert(p);
        }

        public void Update(Service p)
        {
            _ServiceDal.Update(p);
        }
    }
}
