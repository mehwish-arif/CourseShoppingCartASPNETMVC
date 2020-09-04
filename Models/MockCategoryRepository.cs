using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouseCatalogueMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> {
             new Category {
                 CategoryId = 101,
                 Name = "Web Technology",
                 Description = "All Server-side and Client-side Web Technology Services."             
             },
             new Category {
                 CategoryId = 102,
                 Name = "Data Science",
                 Description = "All Data Science related Courses."
             },
             new Category {
                 CategoryId = 103,
                 Name = "Mobile Application Development",
                 Description = "Various courses related to Mobile Application Development"
             }                  
        
        };
    }
}
