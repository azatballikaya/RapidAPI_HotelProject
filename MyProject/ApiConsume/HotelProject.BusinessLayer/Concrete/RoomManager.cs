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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Delete(Room p)
        {
            _roomDal.Delete(p); 
        }

        public Room GetById(int id)
        {
           return _roomDal.GetById(id);
        }

        public List<Room> GetList()
        {
            return _roomDal.GetList();
        }

        public void Insert(Room p)
        {
            _roomDal.Insert(p);
        }

        public void Update(Room p)
        {
            _roomDal.Update(p);
        }
    }
}
