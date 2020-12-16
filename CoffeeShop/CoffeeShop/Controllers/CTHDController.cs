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
    public class CTHDController : Controller
    {
        private readonly ICTHDServices _cthdServices;//khai báo services

        public CTHDController(ICTHDServices cthdServices) //contructor
        {
            _cthdServices = cthdServices;
        }
        public IActionResult Index1(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _cthdServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new CTHDView()
            {
                CTHD = new PaginatedList<CTHDDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _cthdServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new CTHDView()
            {
                CTHD = new PaginatedList<CTHDDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }

        public IActionResult ThemCTHD()
        {
            return View();
        }
        public IActionResult ThemCTHDData(CTHDView cthdView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.menu where u.MaMon == cthdView.cthdDTO.MaMon select u).Single();
                    update.SoLuongTon = update.SoLuongTon- cthdView.cthdDTO.SoLuong;
                    db.SaveChanges();
                }
                _cthdServices.themCTHD(cthdView.cthdDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemCTHD));
                return RedirectToAction("Index", "CTHD");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemCTHD));
        }

        public IActionResult SuaCTHDData(CTHDView cthdView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
               
                _cthdServices.suaCTHD(cthdView.cthdDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                        //return View(nameof(Index));//quay về trang index
                
                return RedirectToAction("Index", "CTHD");
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaCTHD(int id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
        {
            ViewBag.SuaCTHD = _cthdServices.GetCTHD(id);
            return View();
        }


        public IActionResult XoaCTHDData(int id) //truyền mã vào để xóa một đối tượng
        {
            _cthdServices.xoaCTHD(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
                    // return View(nameof(Index)); // trả về view
            return RedirectToAction("Index", "CTHD");

        }
    }
}
