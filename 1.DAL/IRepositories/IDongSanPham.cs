using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDongSanPham
    {
        bool Add(DongSp obj);
        bool Update(DongSp obj);
        bool Delete(DongSp obj);
        DongSp GetById(Guid id);//phuong thuc tim san pham .
        List<DongSp> GetAll();
    }
}
