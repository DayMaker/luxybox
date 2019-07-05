using System.Collections.Generic;
using System.Web.Mvc;
using Luxybox.Models;
using System.Linq;

namespace Luxybox.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            //Helper.BusinessHelper.AddCategory(new Data.Category { Name = "Men" });
            var categories = dbContext.Categories.ToList();//Helper.BusinessHelper.GetCategories();
            return View(categories);
        }

    }
}