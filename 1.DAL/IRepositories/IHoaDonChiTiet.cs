using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTiet
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        HoaDonChiTiet GetById(Guid id);//phuong thuc tim san pham .
        List<HoaDonChiTiet> GetAll();
    }
}
