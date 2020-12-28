using System;
using System.Collections.Generic;
using System.Linq;
using adamgibi2.Data;
using adamgibi2.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace adamgibi2.ViewComponents
{
    public class YorumYap:ViewComponent
    {
        public ApplicationDbContext _db;
        public YorumYap(ApplicationDbContext db)
        {
            _db = db;

        }

      

        [HttpGet]
        public IViewComponentResult Invoke(Blog id)

        { 
            
            ViewBag.deger = id;

           

            return View();
        }
    }
}
