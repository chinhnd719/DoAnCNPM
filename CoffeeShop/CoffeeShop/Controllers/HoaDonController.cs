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
    public class HoaDonController : Controller
    {
        private readonly IHoaDonServices _hoadonServices;//khai báo services
        public HoaDonController(IHoaDonServices hoadonServices) //contructor
        {
            _hoadonServices = hoadonServices;
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _hoadonServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new HoaDonView()
            {
                HoaDon = new PaginatedList<HoaDonDTO>(list, count, pageIndex, pageSize)
            };
            
            return View(indexVM);
            
        }

        public IActionResult ThemHoaDon()
        {
            return View();
        }
        public IActionResult ThemHoaDonData(HoaDonView hoadonView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                //string[] formattedStrings = now.GetDateTimeFormats('T');
                //char[] formats = { 'd', 't' };
                //Console.WriteLine("Now is " + formattedStrings[0]  );
               String date = String.Format("{0:d/M/yyyy}", now);
               String time = String.Format("{0:T}", now);
                hoadonView.hoadonDTO.NgayLapHD = date;
                hoadonView.hoadonDTO.ThoiGian = time;
                _hoadonServices.themHoaDon(hoadonView.hoadonDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemHoaDon));
                return RedirectToAction("Index", "HoaDon");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemHoaDon));
        }

        public IActionResult SuaHoaDonData(HoaDonView hoadonView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _hoadonServices.suaHoaDon(hoadonView.hoadonDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaHoaDon(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
        {
            ViewBag.SuaHoaDon = _hoadonServices.GetHoaDon(id);
            return View();
        }


        public IActionResult XoaHoaDonData(string id) //truyền mã vào để xóa một đối tượng
        {
            _hoadonServices.xoaHoaDon(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
    }
}
