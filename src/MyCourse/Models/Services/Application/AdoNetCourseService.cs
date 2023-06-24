using MyCourse.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.Services.Infrastructure;
using System.Data;

namespace MyCourse.Models.Services.Application
{
    public class AdoNetCourseService : ICourseService
    {
        private readonly IDatabaseAccessor _db;
       public AdoNetCourseService(IDatabaseAccessor db)
       {
            _db = db;
        
       }
        public CourseDetailViewModel GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseViewModel> GetCourses()
        {
             string query = "Select * FROM Courses";
             DataSet dataset=_db.Query(query);
            throw new NotImplementedException();
        }
    }
}