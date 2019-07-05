using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Luxybox.Data;
namespace Luxybox.Helper
{
    public class BusinessHelper
    {
        public static void AddCategory(Category category)
        {
            using (var db = new LuxyBoxEntities())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }
        public static List<Category> GetCategories()
        {
            using (var db = new LuxyBoxEntities())
            {
                var cateogries = db.Categories.ToList();
                return cateogries;
            }
        }
    }
}