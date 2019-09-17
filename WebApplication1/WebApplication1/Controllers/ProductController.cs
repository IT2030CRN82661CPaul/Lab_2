using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public string Index()
        {
            return "Product / Index is displayed";
        }

        // GET: Product/Browse
        public string Browse()
        
        {
            return "Browse displayed";
        }
        // GET: Product/Details/Id
        public string Details(int Id)
        
        {
            return "Details displayed for, Id=" +Id;
        }

        // GET: Product/Location?zip=Zip
        public string Location(string Zip)

        {
            return "Location displayed for, Zip=" +Zip;
        }
    }
}