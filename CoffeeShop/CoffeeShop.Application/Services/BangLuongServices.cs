using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mapping;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class BangLuongServices : IBangLuongServices
    {
        private readonly IBangLuongRepository _bangluongRepository;//Tạo biến chứa dữ liệu 
        public BangLuongServices(IBangLuongRepository bangluongRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _bangluongRepository = bangluongRepository;
        }

        public IEnumerable<BangLuongDTO> getAll(int pageIndex, int pageSize, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _bangluongRepository.getAll(pageIndex, pageSize, out count).MappingBangLuongDTO1();
        }

        public BangLuongDTO GetBangLuong(string maNV)
        {
            return _bangluongRepository.GetBangLuong(maNV).MappingBangLuongDTO();

        }

        public void suaBangLuong(BangLuongDTO bangluongDTO)
        {
            _bangluongRepository.SuaBangLuong(bangluongDTO.MappingBangLuong());
        }

        public void themBangLuong(BangLuongDTO bangluongDTO)
        {
            _bangluongRepository.ThemBangLuong(bangluongDTO.MappingBangLuong());
        }


        public void xoaBangLuong(string maNV)
        {
            _bangluongRepository.XoaBangLuong(maNV);
        }
    }
}
