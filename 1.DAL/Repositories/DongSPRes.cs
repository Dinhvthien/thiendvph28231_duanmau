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
    public class DongSPRes : IDongSanPham
    {
        FpolyDBContext _context;
        public DongSPRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.DongSps.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var temptobj = _context.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            _context.DongSps.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return _context.DongSps.ToList();
        }

        public DongSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.DongSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var temptobj = _context.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            temptobj.Ma = obj.Ma;
            temptobj.Ten = obj.Ten;
            _context.DongSps.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
