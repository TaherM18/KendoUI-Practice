using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/city")]
    public class CityApiController : ControllerBase
    {
        private readonly List<CityModel> cities = new List<CityModel>
        {
            new CityModel { Id = 1, Name = "Ahmedabad", StateCode = "GJ" },
            new CityModel { Id = 2, Name = "Surat", StateCode = "GJ" },
            new CityModel { Id = 3, Name = "Mumbai", StateCode = "MH" },
            new CityModel { Id = 4, Name = "Pune", StateCode = "MH" },
            new CityModel { Id = 5, Name = "Ludhiana", StateCode = "PB" },
            new CityModel { Id = 6, Name = "Amritsar", StateCode = "PB" }
        };

        [HttpGet]
        public IActionResult GetCities() {
            return Ok(new { data = cities });
        }

        [HttpGet("state/{stateCode}")]
        public IActionResult GetCitiesByStateCode(string stateCode) {
            var stateCities = cities.Where(x => x.StateCode.Equals(stateCode));
            return Ok(new { data = stateCities });
        }

        [HttpGet("search")]
        public IActionResult SearchCities([FromQuery] string? query) {
            if (string.IsNullOrEmpty(query))
            {
                return Ok(new { data = new List<CityModel>() });
            }
            var regex = new Regex(query, RegexOptions.IgnoreCase);
            var filteredCities = cities.Where(x => regex.IsMatch(x.Name)).ToList();
            return Ok(new { data = filteredCities });
        }
    }
}