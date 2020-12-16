using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class ChiTietNhapController : Controller
    {
        private readonly IChiTietNhapServices _chitietnhapServices;//khai báo services
        public ChiTietNhapController(IChiTietNhapServices chitietnhapServices) //contructor
        {
            _chitietnhapServices = chitietnhapServices;
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _chitietnhapServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new ChiTietNhapView()
            {
                ChiTietNhap = new PaginatedList<ChiTietNhapDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }

        public IActionResult ThemChiTietNhap()
        {
            return View();
        }
        public IActionResult ThemChiTietNhapData(ChiTietNhapView chitietnhapView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.menu where u.MaMon == chitietnhapView.chitietnhapDTO.MaMon select u).Single();
                    update.SoLuongTon += chitietnhapView.chitietnhapDTO.SoLuong;
                    db.SaveChanges();
                }
                _chitietnhapServices.themChiTietNhap(chitietnhapView.chitietnhapDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemChiTietNhap));
                return RedirectToAction("Index", "ChiTietNhap");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemChiTietNhap));
        }

        public IActionResult SuaChiTietNhapData(ChiTietNhapView chitietnhapView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _chitietnhapServices.suaChiTietNhap(chitietnhapView.chitietnhapDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaChiTietNhap(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
        {
            ViewBag.SuaChiTietNhap = _chitietnhapServices.GetChiTietNhap(id);
            return View();
        }


        public IActionResult XoaChiTietNhapData(string id) //truyền mã vào để xóa một đối tượng
        {
            _chitietnhapServices.xoaChiTietNhap(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
    }
}
