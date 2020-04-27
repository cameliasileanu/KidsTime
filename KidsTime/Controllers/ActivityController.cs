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
    public class ActivityController : Controller
    {
        private readonly IActivityRepository _activityRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ActivityController(IActivityRepository activityRepository, ICategoryRepository categoryRepository)
        {
            _activityRepository = activityRepository;
            _categoryRepository = categoryRepository;
        }
        //public ViewResult List()
        //{
        //    ActivityListViewModel activityListViewModel = new ActivityListViewModel();
        //    activityListViewModel.Activities = _activityRepository.AllActivities;

        //    activityListViewModel.CurentCategory = "";
        //    return View(activityListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Activity> activities;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                activities = _activityRepository.AllActivities.OrderBy(a => a.ActivityId);
                currentCategory = "Toate activitatile";
            }
            else
            {
                activities = _activityRepository.AllActivities.Where(a => a.Category.CategoryName == category)
                    .OrderBy(a => a.ActivityId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ActivityListViewModel
            {
                Activities = activities,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var activity = _activityRepository.GetActivityById(id);
                if (activity==null)              
                    return NotFound();
                    
                 return View(activity);
        }
    }
}
