using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QuanLySanPhamSer : IQuanLySanPhamSer
    {
        private IChitietsanphamRes _IChiTietSanPhamRes;
        public QuanLySanPhamSer()
        {
            _IChiTietSanPhamRes = new ChitietsanphamRes();
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null) return "them khong thanh cong";
            var chiTietSanPham = obj.ChiTietSp;
            if(_IChiTietSanPhamRes.Add(chiTietSanPham)) return "them thanh cong";

            return "them khong thanh cong";
        }

        public string Delete(SanPhamView obj)
        {
            if (obj == null) return "xoa khong thanh cong";
            var chiTietSanPham = obj.ChiTietSp;
            if (_IChiTietSanPhamRes.Add(chiTietSanPham)) return "xoa thanh cong";
            return "xoa khong thanh cong";
        }

        public List<SanPhamView> GetAll()
        {
            
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "Sua khong thanh cong";
            var chiTietSanPham = obj.ChiTietSp;
            if (_IChiTietSanPhamRes.Add(chiTietSanPham)) return "sua thanh cong";
            return "Sua khong thanh cong";
        }
    }
}
