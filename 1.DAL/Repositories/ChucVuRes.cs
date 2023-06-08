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
    public class ChucVuRes : IChucVu
    {//ChucVu obj
        FpolyDBContext _context;
        public ChucVuRes()
        {
            _context = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.ChucVus.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var temptobj = _context.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            _context.ChucVus.Remove(temptobj);
            _context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _context.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.ChucVus.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var temptobj = _context.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            temptobj.Ma = obj.Ma;
            temptobj.Ten = obj.Ten;
            _context.ChucVus.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
