using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Infrastructure.Repository
{
    public class MenuRepository : IMenuRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly CoffeeShopDbContext _conText;//Khởi tạo biến context
        public MenuRepository(CoffeeShopDbContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<Menu> getAll(int pageIndex, int pageSize, out int count)
        {
            count = _conText.menu.Count();

            var query = _conText.menu.AsQueryable();//Trả về kiểu tương tự như list  
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }

        public Menu GetMenu(string maMon)
        {

            return _conText.menu.Find(maMon);
        }

        public void SuaMenu(Menu menu)
        {
            _conText.menu.Update(menu);
            _conText.SaveChanges();
        }

        public void ThemMenu(Menu menu)
        {
            _conText.menu.Add(menu);
            _conText.SaveChanges();
        }

        public void XoaMenu(string maMon)
        {

            var menuDaTimThay = _conText.menu.Find(maMon);
            if (menuDaTimThay != null)
            {
                _conText.menu.Remove(menuDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
