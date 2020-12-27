using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adamgibi2.Data;
using adamgibi2.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace adamgibi2.Controllers
{
    public class Default : Controller
    {
        public List<Blog> c;
        
        public ApplicationDbContext _db;
        public Default(ApplicationDbContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            c = _db.Blogs.ToList();
            return View(c);
            
        }
        public ActionResult About()
        {
            return View();

        }
        

    }
}
