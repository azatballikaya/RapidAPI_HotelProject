using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> GetList();
        T GetById(int id);
    }
}
