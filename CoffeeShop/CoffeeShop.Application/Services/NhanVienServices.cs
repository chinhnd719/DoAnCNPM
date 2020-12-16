using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Application.Services
{

    public class NhanVienServices : INhanVienServices
    { 
        private readonly INhanVienRepository _nhanvienRepository;//Tạo biến chứa dữ liệu 
        public NhanVienServices(INhanVienRepository nhanvienRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _nhanvienRepository = nhanvienRepository;
        }

        public IEnumerable<NhanVienDTO> getAll(int pageIndex, int pageSize,out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _nhanvienRepository.getAll(pageIndex,pageSize,out count).MappingNhanVienDTO1();
        }

        public NhanVienDTO GetNhanVien(string maNV)
        {
           return  _nhanvienRepository.GetNhanVien(maNV).MappingNhanVienDTO();

        }

        public void suaNhanVien(NhanVienDTO nhanvienDTO)
        {
            _nhanvienRepository.SuaNhanVien(nhanvienDTO.MappingNhanVien());
        }

        public void themNhanVien(NhanVienDTO nhanvienDTO)
        {
            _nhanvienRepository.ThemNhanVien(nhanvienDTO.MappingNhanVien());
        }


        public void xoaNhanVien(string maNV)
        {
            _nhanvienRepository.XoaNhanVien(maNV);
        }
    }
}
