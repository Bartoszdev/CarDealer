using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarDealer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private IHostingEnvironment _env;

        public CarController(ICarRepository carRepository, IHostingEnvironment env)
        {
            _carRepository = carRepository;
            _env = env;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_carRepository.TakeAllCars());
        }
        public IActionResult Details(int id)
        {
            var car = _carRepository.TakeCarById(id);

            if (car == null)
                return NotFound();
            return View(car);
            
        }
        public IActionResult Create(string FileName)
        {
            if (!String.IsNullOrWhiteSpace(FileName))
                ViewBag.ImgPath = "/Images/" + FileName;
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.AddCar(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public IActionResult Edit(int id, string FileName)
        {
            var car = _carRepository.TakeCarById(id);

            if (car == null)
                return NotFound();

            if (!String.IsNullOrWhiteSpace(FileName))
                ViewBag.ImgPath = "/Images/" + FileName;
            else
                ViewBag.ImgPath = car.UrlPhoto;

            return View(car);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if(ModelState.IsValid)
            {
                _carRepository.EditCar(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        } 

        public IActionResult Delete(int id)
        {
            var car = _carRepository.TakeCarById(id);

            if (car == null)
                return NotFound();
            return View(car);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, string UrlPhoto)
        {
            var car = _carRepository.TakeCarById(id);
            _carRepository.DeleteCar(car);

            //Usuwanie zdjęcia z serwera 
            if(UrlPhoto != null)
            {
                var webroot = _env.WebRootPath;
                var filePath = Path.Combine(webroot.ToString() + UrlPhoto);

                System.IO.File.Delete(filePath);
                
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormCollection form)
        {
            var webroot = _env.WebRootPath;
            var filePath = Path.Combine(webroot.ToString() + @"\images\" + form.Files[0].FileName);

            if(form.Files[0].FileName.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(stream);
                }
            }

            if (Convert.ToString(form["Id"]) == String.Empty || Convert.ToString(form["Id"]) == "0")
                return RedirectToAction(nameof(Create), new { FileName = Convert.ToString(form.Files[0].FileName) });

            return RedirectToAction(nameof(Edit), new { FileName = Convert.ToString(form.Files[0].FileName), id = Convert.ToString(form["Id"]) });
        }
    }
}
