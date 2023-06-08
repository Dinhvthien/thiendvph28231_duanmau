using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonChiTietRes:IHoaDonChiTiet
    {
        FpolyDBContext _context;
        public HoaDonChiTietRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            obj.IdHoaDon = Guid.NewGuid();
            _context.HoaDonChiTiets.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var temptobj = _context.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            _context.HoaDonChiTiets.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _context.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var temptobj = _context.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            temptobj.SoLuong = obj.SoLuong;
            temptobj.DonGia = obj.DonGia;
            temptobj.IdChiTietSp = obj.IdChiTietSp;

            _context.HoaDonChiTiets.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
