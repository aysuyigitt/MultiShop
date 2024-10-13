using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.CargoDetailDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }
        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var value = _cargoDetailService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail CargoDetail = new CargoDetail()
            {
                SenderCustomer = createCargoDetailDto.SenderCustomer,
                RecieverCustomer = createCargoDetailDto.RecieverCustomer,
                Barcode = createCargoDetailDto.Barcode,
                CargoCompanyId = createCargoDetailDto.CargoCompanyId
            };
            _cargoDetailService.TCreate(CargoDetail);
            return Ok("Kargo detayları başarıyla yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteCargoCustome(int id)
        {
            _cargoDetailService.TDelete(id);
            return Ok("Kargo detayları başarıyla yapıldı");
        }
        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail CargoDetail = new CargoDetail()
            {
                SenderCustomer = updateCargoDetailDto.SenderCustomer,
                RecieverCustomer = updateCargoDetailDto.RecieverCustomer,
                Barcode = updateCargoDetailDto.Barcode,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId
            };
            _cargoDetailService.TUpdate(CargoDetail);
            return Ok("Kargo detayları başarıyla güncellendi");
        }
    }
}