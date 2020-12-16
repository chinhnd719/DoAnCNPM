
using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoffeeShop.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly INhanVienServices _nhanvienServices;//khai báo services

        public NhanVienController(INhanVienServices nhanvienServices) //contructor
        {
            _nhanvienServices = nhanvienServices;
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _nhanvienServices.getAll(pageIndex,pageSize,out count);
            var indexVM = new NhanVienView()
            {
                NhanVien = new PaginatedList<NhanVienDTO>(list,count, pageIndex, pageSize)
            };
        
            return View(indexVM);
        }
        [HttpPost]
        public IActionResult SearchNhanVien(string term)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageIndex = 1;
            int pageSize = 4;
            var list = _nhanvienServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new NhanVienView()
            {
                NhanVien = new PaginatedList<NhanVienDTO>(list, count, pageIndex, pageSize)
            };
            ViewBag.Product = new NhanVienView()
            {
                search = term
            };

            return View(indexVM);
        }
        

        public IActionResult ThemNhanVien()
        { 
           return View();
         }
        public IActionResult ThemNhanVienData(NhanVienView nhanvienView)//thêm đối tượng xuống database
        {
           ViewBag.Error = "1";
         if(ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var luong = new BangLuong
                    {
                        MaNV = nhanvienView.nhanvienDTO.MaNV.ToString(),
                        TienThuong = 0,
                        TamUng = 0,
                        Luong = 0
                        
                    };
                    db.bangluong.Add(luong);
                    db.SaveChanges();
                }
                    
                         _nhanvienServices.themNhanVien(nhanvienView.nhanvienDTO);
             ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemNhanVien));
                return RedirectToAction("Index", "NhanVien");
            }
           ViewBag.Error = "0";
            return View(nameof(ThemNhanVien));
       }

        public IActionResult SuaNhanVienData(NhanVienView nhanvienView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _nhanvienServices.suaNhanVien(nhanvienView.nhanvienDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaNhanVien(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
            
        {
            ViewBag.SuaNhanVien = _nhanvienServices.GetNhanVien(id);
            return View();
        }


        public IActionResult XoaNhanVienData(string id) //truyền mã vào để xóa một đối tượng
        {
            _nhanvienServices.xoaNhanVien(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
    }
}
