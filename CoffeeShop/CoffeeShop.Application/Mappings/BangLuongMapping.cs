using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Mapping
{
    public static class BangLuongMapping
    {
        public static BangLuongDTO MappingBangLuongDTO(this BangLuong bangluong)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new BangLuongDTO
            {
               MaNV=bangluong.MaNV,
               TienThuong=bangluong.TienThuong,
               TamUng=bangluong.TamUng,
               Luong=bangluong.Luong

            };
        }

        public static BangLuong MappingBangLuong(this BangLuongDTO bangluongDTO)
        {
            return new BangLuong
            {
                MaNV = bangluongDTO.MaNV,
                TienThuong = bangluongDTO.TienThuong,
                TamUng = bangluongDTO.TamUng,
                Luong = bangluongDTO.Luong
            };
        }

        public static IEnumerable<BangLuongDTO> MappingBangLuongDTOList(this IEnumerable<BangLuong> bangluongS)
        {
            foreach (var bangluong in bangluongS)
            {
                yield return bangluong.MappingBangLuongDTO();
            }
        }// cái hàm này nè là đang lấy dữ liệu từ entity lên r chuyển sang DTO 
        public static IEnumerable<BangLuongDTO> MappingBangLuongDTO1(this IEnumerable<BangLuong> bangluongS)
        {
            List<BangLuongDTO> listreturn = new List<BangLuongDTO>();
            foreach (var bangluong in bangluongS)
            {
                var obnow = bangluong.MappingBangLuongDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
