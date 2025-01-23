using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DanskeByer.Data;
using DanskeByer.Models;

namespace DanskeByer.Controllers
{
    public class CityController : Controller
    {
        private readonly DanskeByerContext _context;

        public CityController(DanskeByerContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString)
        {
            var cities = from city in _context.City
                         select city;

            if(!string.IsNullOrEmpty(searchString))
            {
                cities = cities.Where(c => c.Name.Contains(searchString));
            }

            var cityList = cities.ToList();

            if (cityList == null | !cityList.Any())
            {
                ViewBag.Message = "No cities found";
            }

            var totalPopulation = cities.Sum(c => c.Population);

            return View(cityList);
        }
    }
}
