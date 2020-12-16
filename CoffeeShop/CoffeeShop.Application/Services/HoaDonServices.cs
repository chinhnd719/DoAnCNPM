using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        private readonly IHoaDonRepository _hoadonRepository;//Tạo biến chứa dữ liệu 
        public HoaDonServices(IHoaDonRepository hoadonRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _hoadonRepository = hoadonRepository;
        }

        public IEnumerable<HoaDonDTO> getAll(int pageIndex, int pageSize, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _hoadonRepository.getAll(pageIndex, pageSize, out count).MappingHoaDonDTO1();
        }

        public HoaDonDTO GetHoaDon(string maHD)
        {
            return _hoadonRepository.GetHoaDon(maHD).MappingHoaDonDTO();

        }

        public void suaHoaDon(HoaDonDTO hoadonDTO)
        {
            _hoadonRepository.SuaHoaDon(hoadonDTO.MappingHoaDon());
        }

        public void themHoaDon(HoaDonDTO hoadonDTO)
        {
            _hoadonRepository.ThemHoaDon(hoadonDTO.MappingHoaDon());
        }


        public void xoaHoaDon(string maHD)
        {
            _hoadonRepository.XoaHoaDon(maHD);
        }
    }
}
