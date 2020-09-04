using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouseCatalogueMVC.Models
{
   public interface ICourseRepository
    {
        IEnumerable<Course> AllCourses { get; }
        IEnumerable<Course> FreeCourseOfTheWeek { get; }
        Course GetCourseById(int courseID);

    }
}
