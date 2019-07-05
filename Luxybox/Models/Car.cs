using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Luxybox.Models
{
    public class Vechile
    {
        protected int Size { get; set; }
        string From { get; set; }
        public Vechile()
        {
            From = "Germany";
        }
    }
    public class Car:Vechile
    {
        public Car()
        {
            Size = 2000;
        }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Colar { get; set; }
        public int Model { get; set; }
        string Destination { get; set; }        
    }
}