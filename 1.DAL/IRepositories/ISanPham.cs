using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPham
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);
        SanPham GetById(Guid id);//phuong thuc tim san pham .
        List<SanPham> GetAll();
    }
}
