


using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Coures()
        {
            var product = new Product  
            {
                Title = "Blender Character Creator v2.0 for Video Games Design",
                Author = "Ralph Edwards",
                OriginalPrice = 18.99m,
                CurrentPrice = 44.99m,
                Hours = 160,
                Rating = 92.0,
                RatingsCount = 3100
            };
            return View(product);
        }
    }
}
