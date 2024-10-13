using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.CargoCustomerDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _cargoCustomerService;

        public CargoCustomersController(ICargoCustomerService cargoCustomerService)
        {
            _cargoCustomerService = cargoCustomerService;
        }
        [HttpGet]
        public IActionResult CargoCustomerList()
        {
            var values = _cargoCustomerService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoCustomerById(int id)
        {
           var value =_cargoCustomerService.TGetById(id);
            return Ok(value);   
        }
        [HttpPost]
        public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Name = createCargoCustomerDto.Name,
                Surname = createCargoCustomerDto.Surname,
                Email = createCargoCustomerDto.Email,
                District = createCargoCustomerDto.District,
                City = createCargoCustomerDto.City,
                Phone = createCargoCustomerDto.Phone,
                Address = createCargoCustomerDto.Address,
                UserCustomerId= createCargoCustomerDto.UserCustomerId,
            };
            _cargoCustomerService.TCreate(cargoCustomer);
            return Ok("Kargo müşteri ekleme başarıyla yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteCargoCustomer(int id)
        {
            _cargoCustomerService.TDelete(id);
            return Ok("Kargo müşteri silme işlemi başarıyla yapıldı");
        }
        [HttpPut]
        public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Name = updateCargoCustomerDto.Name,
                Surname = updateCargoCustomerDto.Surname,
                Email = updateCargoCustomerDto.Email,
                District = updateCargoCustomerDto.District,
                City = updateCargoCustomerDto.City,
                Phone = updateCargoCustomerDto.Phone,
                Address = updateCargoCustomerDto.Address,
                UserCustomerId = updateCargoCustomerDto.UserCustomerId,
            };
            _cargoCustomerService.TUpdate(cargoCustomer);
            return Ok("Kargo müşteri güncelleme işlemi başarıyla yapıldı");
        }
        [HttpGet("GetCargoCustomerById")]
        public IActionResult GetCargoCustomerById(string id)
        {
            return Ok(_cargoCustomerService.TGetCargoCustomerById(id));
        }
    }
}