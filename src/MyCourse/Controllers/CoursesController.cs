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
        public async Task<IActionResult> Index()
        {
 
            List<CourseViewModel> courses = await courseService.GetCoursesAsync();
            return View(courses);
        }

        public async Task<IActionResult> Detail(int id)
        {

            CourseDetailViewModel course= await courseService.GetCoursesAsync(id);
            return View(course);
        }
    }
}