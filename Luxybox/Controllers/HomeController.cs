using System.Web.Mvc;
using System.Linq;
using System.Net;
using Luxybox.Data;
using Luxybox.Models;

namespace Luxybox.Controllers 
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {






            //Helper.BusinessHelper.AddCategory(new Data.Category { Name = "Men" });
            var categories = dbContext.Categories.ToList();//Helper.BusinessHelper.GetCategories();
            var products = dbContext.Products.ToList();
            var model = new HomeModel(categories, products);

            return View(model);
        }
        public ActionResult Products(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var products = dbContext.Products.Where(c => c.CategoryId == id).ToList();
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = dbContext.Products.SingleOrDefault(q => q.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }

}