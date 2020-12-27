using System;
using System.Collections.Generic;
using System.Linq;
using adamgibi2.Data;
using adamgibi2.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace adamgibi2.ViewComponents
{
    public class SonUcBlog : ViewComponent
    {
        
        
        public ApplicationDbContext _db;
        public SonUcBlog(ApplicationDbContext db)
        {
            _db = db;

        }
        public IViewComponentResult Invoke()
        {
            var d = new List<Blog> { }; 



                d = _db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(d); 
        
        }

     }
}
        

    
