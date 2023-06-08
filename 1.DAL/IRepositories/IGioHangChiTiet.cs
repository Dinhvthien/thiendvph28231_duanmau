using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangChiTiet
    {
        bool Add(GioHangChiTiet obj);
        bool Update(GioHangChiTiet obj);
        bool Delete(GioHangChiTiet obj);
        GioHangChiTiet GetById(Guid id);//phuong thuc tim san pham .
        List<GioHangChiTiet> GetAll();
    }
}
