using Bussiness.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {

        private IRentalService _rentalService;
        

        public RentalController(IRentalService rentalService)
        {

            _rentalService = rentalService;

        }
         

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var res = _rentalService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
            

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var res = _rentalService.GetById(id);
            if (res.Success)
            {
                return Ok(res);

            }
            return BadRequest(res);


        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var res = _rentalService.Add(rental);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);


        }
    }
}
