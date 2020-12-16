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
    public class ThongKeController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new CoffeeShopDbContext())
            {
                var thongke= (from u in db.menu select u).Single();
                int x;
                new ThongKeView()
                {
                    TenMon = thongke.TenMon,
                    SoLuong = 100- thongke.SoLuongTon   
                };
            };
            return View();
        }
    }
}
