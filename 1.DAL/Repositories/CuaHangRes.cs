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
    public class CuaHangRes : ICuaHang
    {
        FpolyDBContext _context;
        public CuaHangRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.CuaHangs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var temptobj = _context.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            _context.CuaHangs.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _context.CuaHangs.ToList();
        }

        public CuaHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.CuaHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var temptobj = _context.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            temptobj.Ma = obj.Ma;
            temptobj.Ten = obj.Ten;
            temptobj.DiaChi = obj.DiaChi;
            temptobj.ThanhPho = obj.ThanhPho;
            temptobj.QuocGia = obj.QuocGia;
            _context.CuaHangs.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
