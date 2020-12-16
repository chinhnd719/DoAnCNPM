using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuServices _menuServices;//khai báo services

        public MenuController(IMenuServices menuServices) //contructor
        {
            _menuServices = menuServices;
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _menuServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new MenuView()
            {
                Menu = new PaginatedList<MenuDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }
      
        public IActionResult ThemMenu()
        {
            return View();
        }
        public IActionResult ThemMenuData(MenuView menuView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _menuServices.themMenu(menuView.menuDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemMenu));
                return RedirectToAction("Index", "Menu");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemMenu));
        }

        public IActionResult SuaMenuData(MenuView menuView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _menuServices.suaMenu(menuView.menuDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaMenu(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
                                                 //  truy xuất xuống services/reponsitory để lấy đối tượng lên và gán dữ liệu cho trang SuaMenu

        {
            ViewBag.SuaMenu = _menuServices.GetMenu(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaMenuData(string id) //truyền mã vào để xóa một đối tượng
        {
            _menuServices.xoaMenu(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
    }
}
