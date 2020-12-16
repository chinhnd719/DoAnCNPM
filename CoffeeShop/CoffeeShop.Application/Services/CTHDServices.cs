using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mappings;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class CTHDServices : ICTHDServices
    {
        private readonly ICTHDRepository _cthdRepository;//Tạo biến chứa dữ liệu 
        public CTHDServices(ICTHDRepository cthdRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _cthdRepository = cthdRepository;
        }

        public IEnumerable<CTHDDTO> getAll(int pageIndex, int pageSize, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _cthdRepository.getAll(pageIndex, pageSize, out count).MappingCTHDDTO1();
        }

        public CTHDDTO GetCTHD(int id)
        {
            return _cthdRepository.GetCTHD(id).MappingCTHDDTO();

        }

        public void suaCTHD(CTHDDTO cthdDTO)
        {
            _cthdRepository.SuaCTHD(cthdDTO.MappingCTHD());
        }

        public void themCTHD(CTHDDTO cthdDTO)
        {
            _cthdRepository.ThemCTHD(cthdDTO.MappingCTHD());
        }


        public void xoaCTHD(int id)
        {
            _cthdRepository.XoaCTHD(id);
        }
    }
}
