using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouseCatalogueMVC.Models
{
  public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
