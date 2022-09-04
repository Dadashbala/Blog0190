using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog0190.Models.Sinifler;

namespace Blog0190.Controllers
{
    public class SiteController : Controller
    {
        Context c = new Context();
      
        // GET: Site

        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Blog()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
        [HttpPost]
        public ActionResult Blog(string TextName, Blog blo)
        {
            var blogSiyahisi = c.Blogs.Where(p => p.TextName.Contains(TextName)).ToList();
            return View(blogSiyahisi);
        }

        public ActionResult BlogDetay(int id)
        {
            var blogbul = c.Blogs.Where(x => x.BlogID == id).ToList();
            return View(blogbul);
           
        }
        public ActionResult blogcommentlerigoster(int id)
        {
            var blogbul = c.BlogComments.Where(x => x.BlogID == id).ToList();
            return View(blogbul);
        }
        
        public PartialViewResult LessonSiyahisi2()
        {
            var deyer = c.Lessons.ToList();
            return PartialView(deyer);
        }
        
        public PartialViewResult BlogSiyahisi2()
        {
            var deyer = c.Blogs.ToList();
            return PartialView(deyer);
        }
        //----------------------------------
        [HttpGet]
        public PartialViewResult BlogInTheHome()
        {
            var bloglar = c.Blogs.ToList();
            return PartialView(bloglar);
        }
        [HttpPost]
        public PartialViewResult BlogInTheHome(string TextName, Blog blo)
        {
            var blogSiyahisi = c.Blogs.Where(p => p.TextName.Contains(TextName)).ToList();
            return PartialView(blogSiyahisi);
        }
        //-----------------------------------
        public PartialViewResult LessonInTheHome()
        {
            var lesson = c.Lessons.ToList();
            return PartialView(lesson);
        }
        public PartialViewResult AboutInTheHome()
        {
            var about = c.Abouts.ToList();
            return PartialView(about);
        }
        public ActionResult Lesson()
        {
            var lesson = c.Lessons.ToList();
            return View(lesson);
            
        }
        [HttpPost]
        public ActionResult Lesson(string TextName, LessonInformation blo)
        {
            var less = c.Lessons.Where(p => p.TextName.Contains(TextName)).ToList();
            return View(less);
        }

        public ActionResult LessonDetay( int id)
        {
            var lessonbul = c.Lessons.Where(x => x.LessonID == id).ToList();
            
            return View(lessonbul);
        }
        public ActionResult lessoncommentlerigoster(int id)
        {
            var lessons = c.LessonComments.Where(x => x.LessonID == id).ToList();
            return View(lessons);
        }
        public ActionResult Foto()
        {
            var fotoinformation = c.Fotos.ToList();
            return View(fotoinformation);
        }
        public ActionResult About()
        {
            var deyerler = c.Abouts.ToList();
            return View(deyerler);
        }
        public ActionResult Contact()
        {
            var aboutlocation = c.Abouts.ToList();
            return View(aboutlocation);
        }
        public PartialViewResult PageKecid()
        {
            return PartialView();
        }
        //---------------------------------------------
        IEnumerableClass iemc = new IEnumerableClass();
        public PartialViewResult FooterLayout()
        {
            iemc.AddresDeyer = c.AddresInformations.ToList();
            iemc.ContactDeyer = c.Contacts.ToList();
            iemc.AboutDeyer = c.Abouts.ToList();
            return PartialView(iemc);
        }
        public PartialViewResult TopLayout()
        {
            iemc.AddresDeyer = c.AddresInformations.ToList();
            return PartialView(iemc);
        }
        public PartialViewResult AdressLayout()
        {
            return PartialView();
        }
        //---------------------------------------------------
        // bloga yorum yazmag prosesleri
    
        [HttpGet]
        public PartialViewResult BlogYorumYaz(int id)
        {
            ViewBag.deyer = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult BlogYorumYaz(BlogComment y)
        {
            c.BlogComments.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        //----------------------------------------
        //Lesson a Yorum yazmag prosesi
        [HttpGet]
        public PartialViewResult LessonYorumYaz(int id)
        {
            ViewBag.deyer = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LessonYorumYaz(LessonComment ly)
        {
            c.LessonComments.Add(ly);
            c.SaveChanges();
            return PartialView();
        }
        // Contact seifesinden mesaj gondermek
        //-------------------------------------------
        

        [HttpGet]
        public PartialViewResult ContactSeifesindenMesajGonder()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ContactSeifesindenMesajGonder(Contact contact)
        {
            c.Contacts.Add(contact);
            c.SaveChanges();
            return PartialView();
        }
        //-----------------------------------------
        //Service information
        public ActionResult Service()
        {
            var service = c.services.ToList();
            return View(service);
        }
        [HttpPost]
        public ActionResult Service(string TextName, ServiceInformation blo)
        {
            var servis = c.services.Where(p => p.ServicesName.Contains(TextName)).ToList();
            return View(servis);
        }
        public PartialViewResult AxdarishSistemi()
        {
            return PartialView();
        }
    }
}