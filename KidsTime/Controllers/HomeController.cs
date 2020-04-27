using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KidsTime.Models;
using KidsTime.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KidsTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IActivityRepository _activityRepository;

        public HomeController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.IsActivityStar = _activityRepository.IsActivityStar;

            return View(homeViewModel);
        }
    }
}
