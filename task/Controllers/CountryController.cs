using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task.Model;
using task.services;

namespace task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountry countryService;

        public CountryController(ICountry _icountryService)
        {
            countryService = _icountryService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(countryService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public void create(CountryDTO countryDTO)
        {
            countryService.Save(countryDTO);
        }

        [HttpGet]
        [Route("Search")]
        public List<CountryDTO> Search(string? name)
        {
            return countryService.Search(name);
        }
    }
}
