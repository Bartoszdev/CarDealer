using CarDealer.Models;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarDealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var cars = _carRepository.TakeAllCars().OrderBy(s => s.Brand);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Przegląd samochodów",
                Cars = cars.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var car = _carRepository.TakeCarById(id);

            if(car == null)
            {
                return NotFound();
            }
            return View(car);
        }
    }

   
}
