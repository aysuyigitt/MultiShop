using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.CargoOperationDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _cargoOperationService;

        public CargoOperationsController(ICargoOperationService CargoOperationService)
        {
            _cargoOperationService = CargoOperationService;
        }
        [HttpGet]
        public IActionResult CargoOperationList()
        {
            var values = _cargoOperationService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoOperationById(int id)
        {
            var value = _cargoOperationService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
        {
            CargoOperation CargoOperation = new CargoOperation()
            {
               Barcode = createCargoOperationDto.Barcode,
               Description = createCargoOperationDto.Description,
               OperationDate=createCargoOperationDto.OperationDate,
            };
            _cargoOperationService.TCreate(CargoOperation);
            return Ok("Kargo işlemi başarıyla yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteCargoCustome(int id)
        {
            _cargoOperationService.TDelete(id);
            return Ok("Kargo işlemi başarıyla yapıldı");
        }
        [HttpPut]
        public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
        {
            CargoOperation CargoOperation = new CargoOperation()
            {
                Barcode = updateCargoOperationDto.Barcode,
                Description = updateCargoOperationDto.Description,
                OperationDate = updateCargoOperationDto.OperationDate,
            };
            _cargoOperationService.TUpdate(CargoOperation);
            return Ok("Kargo işlemi başarıyla güncellendi");
        }
    }
}
    
