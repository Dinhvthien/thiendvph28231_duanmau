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
    public class ChitietsanphamRes : IChitietsanphamRes
    {
        FpolyDBContext  _context;
        public ChitietsanphamRes()
        {
             _context = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.ChiTietSps.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var temptobj = _context.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            _context.ChiTietSps.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _context.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.ChiTietSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var temptobj = _context.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            temptobj.GiaBan = obj.GiaBan;
            temptobj.GiaNhap = obj.GiaNhap;
            temptobj.IdDongSp = obj.IdDongSp;
            temptobj.IdMauSac = obj.IdMauSac;
            temptobj.IdNsx = obj.IdNsx;
            temptobj.IdSp = obj.IdSp;
            temptobj.IdSp = obj.IdSp;
            temptobj.NamBh = obj.NamBh;
            temptobj.SoLuongTon = obj.SoLuongTon;
            _context.ChiTietSps.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
