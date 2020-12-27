using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adamgibi2.Data;
using adamgibi2.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace adamgibi2.Controllers
{
    public class About : Controller
    {
        // GET: /<controller>/
        private List<Hakkimizda> c;
        private ApplicationDbContext _db;
        public About(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            c = _db.Hakkimizdas.ToList();
            return View(c);
            
        }
    }
}
