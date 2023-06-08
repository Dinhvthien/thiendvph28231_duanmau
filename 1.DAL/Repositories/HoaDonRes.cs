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
    public class HoaDonRes : IHoaDon
    {
        FpolyDBContext _context;
        public HoaDonRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.HoaDons.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var temptobj = _context.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _context.HoaDons.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _context.HoaDons.ToList();
        }

        public HoaDon GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var temptobj = _context.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            temptobj.IdKh = obj.IdKh;
            temptobj.IdNv = obj.IdNv;
            temptobj.Ma = obj.Ma;
            temptobj.NgayTao = obj.NgayTao;
            temptobj.NgayNhan = obj.NgayNhan;
            _context.HoaDons.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
