using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;
using MyCourse.Models.Services.Infrastructure;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public readonly ICourseService courseService;
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
            
        }
        public IActionResult Index()
        {
 
            List<CourseViewModel> courses =  courseService.GetCourses();
            return View(courses);
        }

        public IActionResult Detail(int id)
        {

            CourseDetailViewModel course=courseService.GetCourse(id);
            return View(course);
        }
    }
}