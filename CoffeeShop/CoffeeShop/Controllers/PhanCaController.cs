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
    public class PhanCaController : Controller
    {
        private readonly IPhanCaServices _phancaServices;//khai báo services

        public PhanCaController(IPhanCaServices phancaServices) //contructor
        {
            _phancaServices = phancaServices;
        }
        public IActionResult Index(int pageIndex = 1)//pageIndex được mặc định là 1 nếu không có truyền vào
        {
            int count;
            int pageSize = 4;
            var list = _phancaServices.getAll(pageIndex, pageSize, out count);
            var indexVM = new PhanCaView()
            {
                PhanCa = new PaginatedList<PhanCaDTO>(list, count, pageIndex, pageSize)
            };

            return View(indexVM);
        }

        public IActionResult ThemPhanCa()
        {
            return View();
        }
        public IActionResult ThemPhanCaData(PhanCaView phancaView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                using (var db = new CoffeeShopDbContext())
                {
                    var update = (from u in db.bangluong where u.MaNV == phancaView.phancaDTO.MaNV select u).Single();
                   if (phancaView.phancaDTO.HeSoLuong==1) update.Luong +=  phancaView.phancaDTO.SoGio*20000;
                    else update.Luong += phancaView.phancaDTO.SoGio * 30000;
                    db.SaveChanges();
                }
                _phancaServices.themPhanCa(phancaView.phancaDTO);
                ViewBag.Success = "Đã thêm thành công";
                //return Redirect(nameof(ThemPhanCa));
                return RedirectToAction("Index", "PhanCa");
            }
            ViewBag.Error = "0";
            return View(nameof(ThemPhanCa));
        }

        public IActionResult SuaPhanCaData(PhanCaView phancaView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _phancaServices.suaPhanCa(phancaView.phancaDTO);//gọi hàm sửa ở services
               
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaPhanCa(int id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
                                                   //giao diện QuanLiThuongHieu/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaThuongHieu

        {
            ViewBag.SuaPhanCa = _phancaServices.GetPhanCa(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaPhanCaData(int id) //truyền mã vào để xóa một đối tượng
        {
            _phancaServices.xoaPhanCa(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view

        }
    }
}
