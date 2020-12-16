using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class HoaDonRepository : IHoaDonRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly CoffeeShopDbContext _conText;//Khởi tạo biến context
        public HoaDonRepository(CoffeeShopDbContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<HoaDon> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.hoadon.Count();

            var query = _conText.hoadon.AsQueryable();//Trả về kiểu tương tự như list  
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }

        public HoaDon GetHoaDon(string maHD)
        {

            return _conText.hoadon.Find(maHD);
        }

        public void SuaHoaDon(HoaDon hoadon)
        {
            _conText.hoadon.Update(hoadon);
            _conText.SaveChanges();
        }

        public void ThemHoaDon(HoaDon hoadon)
        {
            _conText.hoadon.Add(hoadon);
            _conText.SaveChanges();
        }

        public void XoaHoaDon(string maHD)
        {

            var hoadonDaTimThay = _conText.hoadon.Find(maHD);
            if (hoadonDaTimThay != null)
            {
                _conText.hoadon.Remove(hoadonDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
