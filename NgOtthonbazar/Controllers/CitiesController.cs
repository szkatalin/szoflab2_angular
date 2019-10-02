using Microsoft.AspNetCore.Mvc;
using Otthonbazar.Data;
using System.Collections.Generic;
using System.Linq;

namespace NgOtthonbazar.Controllers
{
    [Route("api/cities")]
    public class CitiesController
    {
        private readonly ApplicationDbContext _context;
        public CitiesController(ApplicationDbContext context) => _context = context;

        [HttpGet]
        public IEnumerable<City> Get(string cityNamePrefix = null, int? zip = null)
            => _context.Cities.Where(c => 
                (cityNamePrefix == null || c.Name.StartsWith(cityNamePrefix)) 
                && (zip == null || c.Zip == zip.ToString())).Take(10);
    }
}
