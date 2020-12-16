using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mappings
{
    public static class HoaDonMapping
    {
        public static HoaDonDTO MappingHoaDonDTO(this HoaDon hoadon)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new HoaDonDTO
            {
                MaHD = hoadon.MaHD,
                NgayLapHD= hoadon.NgayLapHD,
                ThoiGian=hoadon.ThoiGian,
                SoLuong=hoadon.SoLuong,
                MaNV=hoadon.MaNV
            };
        }

        public static HoaDon MappingHoaDon(this HoaDonDTO hoadonDTO)
        {
            return new HoaDon
            {
                MaHD = hoadonDTO.MaHD,
                NgayLapHD = hoadonDTO.NgayLapHD,
                ThoiGian = hoadonDTO.ThoiGian,
                SoLuong = hoadonDTO.SoLuong,
                MaNV = hoadonDTO.MaNV
            };
        }

        public static IEnumerable<HoaDonDTO> MappingHoaDonDTOList(this IEnumerable<HoaDon> hoadonS)
        {
            foreach (var hoadon in hoadonS)
            {
                yield return hoadon.MappingHoaDonDTO();
            }
        }// cái hàm này nè là đang lấy dữ liệu từ entity lên r chuyển sang DTO 
        public static IEnumerable<HoaDonDTO> MappingHoaDonDTO1(this IEnumerable<HoaDon> hoadonS)
        {
            List<HoaDonDTO> listreturn = new List<HoaDonDTO>();
            foreach (var hoadon in hoadonS)
            {
                var obnow = hoadon.MappingHoaDonDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
