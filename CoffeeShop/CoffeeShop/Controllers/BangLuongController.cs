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
    public class BangLuongController : Controller
    {
        private readonly IBangLuongServices _bangluongServices;//khai báo services

        public BangLuongController(IBangLuongServices bangluongServices) //contructor
        {
            _bangluongServices = bangluongServices;
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _bangluongServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new BangLuongView()
            {
                BangLuong = new PaginatedList<BangLuongDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }

        public IActionResult ThemBangLuong()
        {
            return View();
        }
        public IActionResult ThemBangLuongData(BangLuongView bangluongView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _bangluongServices.themBangLuong(bangluongView.bangluongDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemBangLuong));
                return RedirectToAction("Index", "BangLuong");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemBangLuong));
        }

        public IActionResult SuaBangLuongData(BangLuongView bangluongView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {

                bangluongView.bangluongDTO.Luong= bangluongView.bangluongDTO.Luong - bangluongView.bangluongDTO.TamUng + bangluongView.bangluongDTO.TienThuong;
                _bangluongServices.suaBangLuong(bangluongView.bangluongDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaBangLuong(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
                                                   //giao diện QuanLiThuongHieu/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaThuongHieu

        {
            ViewBag.SuaBangLuong = _bangluongServices.GetBangLuong(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaBangLuongData(string id) //truyền mã vào để xóa một đối tượng
        {
            _bangluongServices.xoaBangLuong(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
    }
}
