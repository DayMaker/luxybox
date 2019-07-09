using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Luxybox.Data;

namespace Luxybox.Models
{
    public class HomeModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public HomeModel(List<Category> categories, List<Product> products)
        {
            Categories = categories;
            Products = products;
        }
    }
}