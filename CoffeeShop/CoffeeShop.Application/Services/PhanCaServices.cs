using CoffeeShop.Application.DomainDTO;
using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Mapping;
using CoffeeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Application.Services
{
    public class PhanCaServices : IPhanCaServices
    {
        private readonly IPhanCaRepository _phancaRepository;//Tạo biến chứa dữ liệu 
        public PhanCaServices(IPhanCaRepository phancaRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _phancaRepository = phancaRepository;
        }

        public IEnumerable<PhanCaDTO> getAll(int pageIndex, int pageSize, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _phancaRepository.getAll(pageIndex, pageSize, out count).MappingPhanCaDTO1();
        }

        public PhanCaDTO GetPhanCa(int id)
        {
            return _phancaRepository.GetPhanCa(id).MappingPhanCaDTO();

        }

        public void suaPhanCa(PhanCaDTO phancaDTO)
        {
            _phancaRepository.SuaPhanCa(phancaDTO.MappingPhanCa());
        }

        public void themPhanCa(PhanCaDTO phancaDTO)
        {
            _phancaRepository.ThemPhanCa(phancaDTO.MappingPhanCa());
        }


        public void xoaPhanCa(int id)
        {
            _phancaRepository.XoaPhanCa(id);
        }
    }
}
