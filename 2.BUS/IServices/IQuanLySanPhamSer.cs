﻿using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQuanLySanPhamSer
    {
        string Add(SanPhamView obj);
        string Update(SanPhamView obj);
        string Delete(SanPhamView obj);
        List<SanPhamView> GetAll();
    }
}
