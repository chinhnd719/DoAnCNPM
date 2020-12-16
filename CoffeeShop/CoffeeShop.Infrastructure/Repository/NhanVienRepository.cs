using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Infrastructure.Persistence
{
    public class NhanVienRepository : INhanVienRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly CoffeeShopDbContext _conText;//Khởi tạo biến context
        public NhanVienRepository(CoffeeShopDbContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<NhanVien> getAll(int pageIndex, int pageSize,out int count)
        {  
            count=_conText.nhanvien.Count();

            var query = _conText.nhanvien.AsQueryable();//Trả về kiểu tương tự như list  
            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }

        public NhanVien GetNhanVien(string maNV)
        {

            return _conText.nhanvien.Find(maNV); 
        }

        public void SuaNhanVien(NhanVien nhanvien)
        {
            _conText.nhanvien.Update(nhanvien);
            _conText.SaveChanges();
        }

        public void ThemNhanVien(NhanVien nhanvien)
        {
            _conText.nhanvien.Add(nhanvien);
            _conText.SaveChanges();
        }

        public void XoaNhanVien(string maNV)
        {
            
            var nhanvienDaTimThay = _conText.nhanvien.Find(maNV);
            if (nhanvienDaTimThay != null)
            {
                _conText.nhanvien.Remove(nhanvienDaTimThay);
                _conText.SaveChanges();
            }
        }
    }
}
