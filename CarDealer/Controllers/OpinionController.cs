using CarDealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository _opinionRepository;

        public OpinionController(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _opinionRepository.AddOpinion(opinion);
                return RedirectToAction("OpinionSended");
            }
            else
            {
                return View(opinion); 
            }
        }

        public IActionResult OpinionSended()
        {
            return View();
        }
    }
}
