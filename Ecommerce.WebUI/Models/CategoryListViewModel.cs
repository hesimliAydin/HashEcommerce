using Ecommerce.Entities.Models;

namespace Ecommerce.WebUI
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}