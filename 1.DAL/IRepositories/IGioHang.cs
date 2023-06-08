using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHang
    {
        bool Add(GioHang obj);
        bool Update(GioHang obj);
        bool Delete(GioHang obj);
        GioHang GetById(Guid id);//phuong thuc tim san pham .
        List<GioHang> GetAll();
    }
}
