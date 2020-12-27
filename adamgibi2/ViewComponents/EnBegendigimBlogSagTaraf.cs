using System;
using System.Collections.Generic;
using System.Linq;
using adamgibi2.Data;
using adamgibi2.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace adamgibi2.ViewComponents
{
    public class EnBegendigimBlogSagTaraf : ViewComponent
    {

        public ApplicationDbContext _db;
        public EnBegendigimBlogSagTaraf(ApplicationDbContext db)
        {
            _db = db;

        }

        public IViewComponentResult Invoke()
        {
            var d = new List<Blog> { };
            d = _db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return View(d);

        }

    }
}
