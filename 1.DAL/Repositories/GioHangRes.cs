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
    public class GioHangRes:IGioHang
    {
        FpolyDBContext _context;
        public GioHangRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(GioHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.GioHangs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(GioHang obj)
        {
            if (obj == null) return false;
            var temptobj = _context.GioHangs.FirstOrDefault(c => c.Id == obj.Id);
            _context.GioHangs.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<GioHang> GetAll()
        {
            return _context.GioHangs.ToList();
        }

        public GioHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.GioHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(GioHang obj)
        {
            if (obj == null) return false;
            var temptobj = _context.GioHangs.FirstOrDefault(c => c.Id == obj.Id);
            temptobj.Ma = obj.Ma;
            temptobj.NgayTao = obj.NgayTao;
            temptobj.NgayThanhToan = obj.NgayThanhToan;
            temptobj.TenNguoiNhan = obj.TenNguoiNhan;
            temptobj.DiaChi = obj.DiaChi;
            temptobj.Sdt = obj.Sdt;
            temptobj.TinhTrang = obj.TinhTrang;
            temptobj.IdKh = obj.IdKh;
            temptobj.IdNv = obj.IdNv;
            _context.GioHangs.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
