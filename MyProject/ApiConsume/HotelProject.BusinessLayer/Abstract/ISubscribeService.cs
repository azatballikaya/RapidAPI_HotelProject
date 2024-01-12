using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface ISubscribeService:IGenericService<Subscribe>
    {
        void Insert(Subscribe p);
        void Delete(Subscribe p);
        void Update(Subscribe p);
        List<Subscribe> GetList();
        Subscribe GetById(int id);
    }
}
