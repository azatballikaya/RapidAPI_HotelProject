using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IServiceService:IGenericService<Service>
    {
        void Insert(Service p);
        void Delete(Service p);
        void Update(Service p);
        List<Service> GetList();
        Service GetById(int id);
    }
}
