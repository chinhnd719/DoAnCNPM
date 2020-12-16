
using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Application.Mappings
{
    public static class NhanVienMapping
    {
        public static NhanVienDTO MappingNhanVienDTO(this NhanVien nhanvien)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new NhanVienDTO
            {
                MaNV=nhanvien.MaNV, 
                TenNV=nhanvien.TenNV,
                HoNV= nhanvien.HoNV,
                SDT= nhanvien.SDT,
                GioiTinh= nhanvien.GioiTinh


            };
        }

        public static NhanVien MappingNhanVien(this NhanVienDTO nhanvienDTO)
        {
            return new NhanVien
            {
                MaNV = nhanvienDTO.MaNV,
                TenNV = nhanvienDTO.TenNV,
                HoNV = nhanvienDTO.HoNV,
                SDT = nhanvienDTO.SDT,
                GioiTinh = nhanvienDTO.GioiTinh
            };
        }

        public static IEnumerable<NhanVienDTO> MappingNhanVienDTOList(this IEnumerable<NhanVien> nhanvienS)
        {
            foreach (var nhanvien in nhanvienS)
            {
                yield return nhanvien.MappingNhanVienDTO();
            }
        }// cái hàm này nè là đang lấy dữ liệu từ entity lên r chuyển sang DTO 
        public static IEnumerable<NhanVienDTO> MappingNhanVienDTO1(this IEnumerable<NhanVien> nhanvienS)
        {
            List<NhanVienDTO> listreturn = new List<NhanVienDTO>(); 
            foreach (var nhanvien in nhanvienS)
            {
                var obnow = nhanvien.MappingNhanVienDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
