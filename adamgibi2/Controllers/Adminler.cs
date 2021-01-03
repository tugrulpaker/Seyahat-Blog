using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adamgibi2.Data;
using adamgibi2.Models.Siniflar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace adamgibi2.Controllers
{
    public class Adminler : Controller
    {
        public List<Blog> c;
        public ApplicationDbContext _db;
        public Adminler(ApplicationDbContext db)
        {
            _db = db;
        }
        [Authorize]
        public IActionResult Index()
        {
            c = _db.Blogs.ToList();

            return View(c);

        }
        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();

        }
        [Authorize]
        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            _db.Add(p);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
            //return View();

        }
        public IActionResult BlogSil(int id)
        {

            var b = _db.Blogs.Find(id);
            _db.Blogs.Remove(b);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public IActionResult BlogGetir (int id)
        {
            var bl = _db.Blogs.Find(id);
            return View("BlogGetir", bl);

        }
        
        public IActionResult BlogGuncelle(Blog b)
        {
            var blg = _db.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = _db.Yorumlars.ToList();
            return View(yorumlar);

        }
        public IActionResult YorumSil(int id)
        {

            var b = _db.Yorumlars.Find(id);
            _db.Yorumlars.Remove(b);
            _db.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        [Authorize]
        public IActionResult YorumGetir(int id)
        {
            var yr = _db.Yorumlars.Find(id);
            return View("YorumGetir", yr);

        }
        public IActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = _db.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            _db.SaveChanges();
            return RedirectToAction("YorumListesi");

        }


    }
}
