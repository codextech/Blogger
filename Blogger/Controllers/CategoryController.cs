using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blogger.Models;

namespace Blogger.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController()
        {
            _context = new ApplicationDbContext();

        }
        // GET: Category
        public PartialViewResult CategoryPartial()
        {
           var categories= _context.Categories.OrderBy(c=>c.CategoryName).ToList();
            return PartialView(categories);
        }


        


    }
}