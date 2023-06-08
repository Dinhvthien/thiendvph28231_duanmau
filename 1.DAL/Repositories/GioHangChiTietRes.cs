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
    public class GioHangChiTietRes : IGioHangChiTiet
    {
        FpolyDBContext _context;
        public GioHangChiTietRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            obj.IdGioHang = Guid.NewGuid();
            _context.GioHangChiTiets.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var temptobj = _context.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang;
            _context.GioHangChiTiets.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GetAll()
        {
            return _context.GioHangChiTiets.ToList();
        }

        public GioHangChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == id);
        }

        public bool Update(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var temptobj = _context.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            temptobj.SoLuong = obj.SoLuong;
            temptobj.DonGia = obj.DonGia;
            temptobj.DonGiaKhiGiam = obj.DonGiaKhiGiam;
            temptobj.IdChiTietSp = obj.IdChiTietSp;
            _context.GioHangChiTiets.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
