using HotelFacilities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HotelFacilities.Controllers
{
    public class HomeController : Controller
    {
        private readonly HotelContext _dbContext;

        public HomeController(HotelContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {

            var _emplst = _dbContext.HotelFacilitiesCats.
                          Join(_dbContext.HotelFacilities, c => c.Id , f=> f.CatId,
                          (c, f) => new HotelFacilitiesViewModel
                          {
                              Id = c.Id,
                              CatId = f.Id,
                              CatName = c.CatName,
                              Title= f.Title
                          }).ToList();
            IList<HotelFacilitiesViewModel> emplst = _emplst;
            return View(emplst);
          //  return View();
        }
    }
}
