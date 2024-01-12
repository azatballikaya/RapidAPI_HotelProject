using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IRoomService:IGenericService<Room>
    {
        void Insert(Room p);
        void Delete(Room p);
        void Update(Room p);
        List<Room> GetList();
        Room GetById(int id);
    }
}
