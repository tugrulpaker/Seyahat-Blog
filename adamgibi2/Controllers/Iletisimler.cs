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
    public class Iletisimler : Controller
    {

        public ApplicationDbContext _db;
        public Iletisimler(ApplicationDbContext db)

        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        // GET: /<controller>/
        public async Task<IActionResult> BizeUlas(Iletisim p)

        {
            _db.Iletisims.Add(p);
            await _db.SaveChangesAsync();
            return Redirect("/");
        }

            
        
        
    }
}
