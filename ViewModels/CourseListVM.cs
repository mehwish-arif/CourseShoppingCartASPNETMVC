using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouseCatalogueMVC.Models;

namespace CouseCatalogueMVC.ViewModels
{
    public class CourseListVM
    {
        public IEnumerable<Course> Courses { get; set; }
        public string SelectedCategoryName { get; set; }
    }
}
