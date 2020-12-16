using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class CTHDRepository : ICTHDRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly CoffeeShopDbContext _conText;//Khởi tạo biến context
        public CTHDRepository(CoffeeShopDbContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<CTHD> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.cthd.Count();

            var query = _conText.cthd.AsQueryable();//Trả về kiểu tương tự như list  
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }

        public CTHD GetCTHD(int id)
        {

            return _conText.cthd.Find(id);
        }

        public void SuaCTHD(CTHD cthd)
        {
            _conText.cthd.Update(cthd);
            _conText.SaveChanges();
        }

        public void ThemCTHD(CTHD cthd)
        {
            _conText.cthd.Add(cthd);
            _conText.SaveChanges();
        }

        public void XoaCTHD(int id)
        {

            var cthdDaTimThay = _conText.cthd.Find(id);
            if (cthdDaTimThay != null)
            {
                _conText.cthd.Remove(cthdDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
