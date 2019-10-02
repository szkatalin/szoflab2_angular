using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NgOtthonbazar.Search;
using Otthonbazar.Data;
using Otthonbazar.Models;
using PagedList.Core;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static NgOtthonbazar.Search.SearchModelClause;

namespace NgOtthonbazar.Controllers
{
    [Route("api/advertisements")]
    public class AdvertisementsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        public AdvertisementsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        private static IEnumerable<ISearchModelClause> Clauses { get; } = new List<ISearchModelClause>
        {
            CreateClause(s => s.PriceMin, c => a => a.Price >= c),
            CreateClause(s => s.PriceMax, c => a => a.Price <= c),
            CreateClause(s => s.SizeMin, c => a => a.Size >= c),
            CreateClause(s => s.SizeMax, c => a => a.Size <= c),
            CreateClause(s => s.RoomMin, c => a => a.Room + a.HalfRoom >= c),
            CreateClause(s => s.RoomMax, c => a => a.Room + a.HalfRoom <= c),
            CreateClause(s => s.CityName, c => a => a.City.Name.Contains(c))
        };

        [HttpGet]
        public IPagedList<Advertisement> Search([FromQuery]SearchModel searchModel)
            => Clauses.Aggregate((IQueryable<Advertisement>)_context.Advertisements,
                (acc, clause) => clause.ApplyClause(acc, searchModel))
                    .Include(a => a.City).ToPagedList(searchModel.Page ?? 1, searchModel.PageSize ?? int.MaxValue);

        [HttpGet("{id}", Name = "AdvertisementDetails")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult<Advertisement> Details(int? id)
            => id == null
                ? NotFound()
                : (ActionResult<Advertisement>)_context.Advertisements.Include(a => a.City).SingleOrDefault(m => m.Id == id)
                    ?? NotFound();

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(Advertisement), (int)HttpStatusCode.Created)]
        public IActionResult CreateOrUpdate([FromBody]Advertisement advertisement)
        {
            if (ModelState.IsValid)
            {
                advertisement.City = null;
				var state = advertisement.Id == 0 ? EntityState.Added : EntityState.Modified;
                _context.Attach(advertisement).State = state;
                _context.SaveChanges();
                return CreatedAtRoute("AdvertisementDetails", new { id = advertisement.Id }, advertisement);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Delete(int? id)
        {
            if (!_context.Advertisements.Any(m => m.Id == id))
                return NoContent();

            _context.Remove(new Advertisement { Id = id.Value });
            _context.SaveChanges();
            return NoContent();
        }
    }
}
