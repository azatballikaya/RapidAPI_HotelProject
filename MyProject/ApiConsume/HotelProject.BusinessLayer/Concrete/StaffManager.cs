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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _StaffDal;

        public StaffManager(IStaffDal StaffDal)
        {
            _StaffDal = StaffDal;
        }

        public void Delete(Staff p)
        {
            _StaffDal.Delete(p); 
        }

        public Staff GetById(int id)
        {
           return _StaffDal.GetById(id);
        }

        public List<Staff> GetList()
        {
            return _StaffDal.GetList();
        }

        public void Insert(Staff p)
        {
            _StaffDal.Insert(p);
        }

        public void Update(Staff p)
        {
            _StaffDal.Update(p);
        }
    }
}
