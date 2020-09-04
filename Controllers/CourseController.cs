using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CouseCatalogueMVC.Models;
using CouseCatalogueMVC.ViewModels;

namespace CouseCatalogueMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ICategoryRepository categoryRepository;

        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository)
        {
            this.courseRepository = courseRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            // ViewBag.SelectedCategory = categoryRepository.AllCategories.ToList()[2].Name;
            // return View(courseRepository.AllCourses);

            CourseListVM courseListVM = new CourseListVM() {

                Courses = courseRepository.AllCourses,
                SelectedCategoryName = categoryRepository.AllCategories.ToList()[2].Name
                            
            };

            return View(courseListVM);
        }

        public IActionResult Details (int id )
        {
            var course = courseRepository.GetCourseById(id);
            return View(course);
        }


    }
}
