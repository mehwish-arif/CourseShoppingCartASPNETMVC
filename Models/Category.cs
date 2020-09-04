using System.Collections.Generic;

namespace CouseCatalogueMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Course> Course { get; set; }
    }
}