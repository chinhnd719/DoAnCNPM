using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class ChiTietNhapServices : IChiTietNhapServices
    {
        private readonly IChiTietNhapRepository _chitietnhapRepository;//Tạo biến chứa dữ liệu 
        public ChiTietNhapServices(IChiTietNhapRepository chitietnhapRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _chitietnhapRepository = chitietnhapRepository;
        }

        public IEnumerable<ChiTietNhapDTO> getAll(int pageIndex, int pageSize, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _chitietnhapRepository.getAll(pageIndex, pageSize, out count).MappingChiTietNhapDTO1();
        }

        public ChiTietNhapDTO GetChiTietNhap(string maNhap)
        {
            return _chitietnhapRepository.GetChiTietNhap(maNhap).MappingChiTietNhapDTO();

        }

        public void suaChiTietNhap(ChiTietNhapDTO chitietnhapDTO)
        {
            _chitietnhapRepository.SuaChiTietNhap(chitietnhapDTO.MappingChiTietNhap());
        }

        public void themChiTietNhap(ChiTietNhapDTO chitietnhapDTO)
        {
            _chitietnhapRepository.ThemChiTietNhap(chitietnhapDTO.MappingChiTietNhap());
        }


        public void xoaChiTietNhap(string maNhap)
        {
            _chitietnhapRepository.XoaChiTietNhap(maNhap);
        }
    }
}
