using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rotativa;
using System.Web.Mvc;
using System.Web.Security;
using Blog0190.Models.Sinifler;

namespace Blog0190.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        [HttpGet]
        public ActionResult Blog()
        {
            var blogSiyahisi = c.Blogs.ToList();
            return View(blogSiyahisi);
        }
        [HttpPost]
        public ActionResult Blog(string TextName, Blog blo)
        {
            var blogSiyahisi = c.Blogs.Where(p => p.TextName.Contains(TextName)).ToList();
            return View(blogSiyahisi);
        }
        public ActionResult ExportPDFBlog()
        {
            return new ActionAsPdf("Blog")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog( Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Blog");
        }
        public ActionResult BlogSil(int id)
        {
            var blogSil = c.Blogs.Find(id);
            c.Blogs.Remove(blogSil);
            c.SaveChanges();
            return RedirectToAction("Blog");
        }
        public ActionResult BlogGetir(int id)
        {
            var bg = c.Blogs.Find(id);
            return View("BlogGetir", bg);
        }

        public ActionResult BlogYenile(Blog b)
        {
            var blg = c.Blogs.Find(b.BlogID);
            blg.TextName = b.TextName;
            blg.Text = b.Text;
            blg.Image = b.Image;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Blog");
        }
        //------------------------------------------------
        [HttpGet]
        public ActionResult Lesson()
        {
            var lessinsiyahisi = c.Lessons.ToList();
            return View(lessinsiyahisi);
        }
        [HttpPost]
        public ActionResult Lesson(string TextName, LessonInformation li)
        {
            var lessinsiyahisi = c.Lessons.Where(p => p.TextName.Contains(TextName)).ToList();
            return View(lessinsiyahisi);
        }
        public ActionResult ExportPDFLesson()
        {
            return new ActionAsPdf("Lesson")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        public ActionResult LessonSil(int id)
        {
            var lessonabc = c.Lessons.Find(id);
            c.Lessons.Remove(lessonabc);
            c.SaveChanges();
            return RedirectToAction("Lesson");
        }
        [HttpGet]
        public ActionResult YeniLesson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniLesson(LessonInformation l)
        {
            c.Lessons.Add(l);
            c.SaveChanges();
            return RedirectToAction("Lesson");
        }

        public ActionResult LessonGetir(int id)
        {
            var lg = c.Lessons.Find(id);
            return View("LessonGetir", lg);
        }

        public ActionResult LessonYenile(LessonInformation b)
        {
            var blg = c.Lessons.Find(b.LessonID);
            blg.TextName = b.TextName;
            blg.Text = b.Text;
            blg.Image = b.Image;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Lesson");
        }
        //----------------------------------------------------
        public ActionResult About()
        {
            var haqqindasiyahisi = c.Abouts.ToList();
            return View(haqqindasiyahisi);
        }
        public ActionResult AboutSil(int id)
        {
            var about = c.Abouts.Find(id);
            c.Abouts.Remove(about);
            c.SaveChanges();
            return RedirectToAction("About");
        }
        public ActionResult ExportPDFAbout()
        {
            return new ActionAsPdf("About")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        [HttpGet]
        public ActionResult YeniAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniAbout(About a)
        {
            c.Abouts.Add(a);
            c.SaveChanges();
            return RedirectToAction("About");
        }
        public ActionResult AboutGetir(int id)
        {
            var lg = c.Abouts.Find(id);
            return View("AboutGetir", lg);
        }

        public ActionResult AboutYenile(About b)
        {
            var blg = c.Abouts.Find(b.AboutID);
            blg.TextName = b.TextName;
            blg.Text = b.Text;
            blg.CV = b.CV;
            blg.BigFoto = b.BigFoto;
            blg.FotoOne = b.FotoOne;
            blg.FotoTwo = b.FotoTwo;
            blg.Location = b.Location;
            blg.QrCode = b.QrCode;
            c.SaveChanges();
            return RedirectToAction("About");
        }
        //----------------------------------------------------
        public ActionResult AddressInformation()
        {
            var adresinformation = c.AddresInformations.ToList();
            return View(adresinformation);
        }
        public ActionResult AdresInformationSil(int id)
        {
            var adres = c.AddresInformations.Find(id);
            c.AddresInformations.Remove(adres);
            c.SaveChanges();
            return RedirectToAction("AddressInformation");
        }
        public ActionResult ExportPDFAdresInformation()
        {
            return new ActionAsPdf("AddressInformation")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        [HttpGet]
        public ActionResult YeniAdress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniAdress(AddresInformation a)
        {
            c.AddresInformations.Add(a);
            c.SaveChanges();
            return RedirectToAction("AddressInformation");
        }
        public ActionResult AdressGetir(int id)
        {
            var adres = c.AddresInformations.Find(id);
            return View("AdressGetir", adres);
        }

        public ActionResult AdressYenile(AddresInformation adresparametr)
        {
            var adres = c.AddresInformations.Find(adresparametr.ID);
            adres.Tel = adresparametr.Tel;
            adres.Email = adresparametr.Email;
            adres.Adres = adresparametr.Adres;
          
            c.SaveChanges();
            return RedirectToAction("AddressInformation");
        }
        //------------------------------------------------------
        public ActionResult Foto()
        {
            var foto = c.Fotos.ToList();
            return View(foto);
        }

        public ActionResult FotoSil(int id)
        {
            var foto = c.Fotos.Find(id);
            c.Fotos.Remove(foto);
            c.SaveChanges();
            return RedirectToAction("Foto");
        }
        public ActionResult ExportPDFFoto()
        {
            return new ActionAsPdf("Foto")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        [HttpGet]
        public ActionResult YeniFoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniFoto(Foto f)
        {
            c.Fotos.Add(f);
            c.SaveChanges();
            return RedirectToAction("Foto");
        }
        public ActionResult FotoGetir(int id)
        {
            var adres = c.Fotos.Find(id);
            return View("FotoGetir", adres);
        }

        public ActionResult FotoYenile(Foto f)
        {
            var adres = c.Fotos.Find(f.FotoId);
            adres.FotoUrl = f.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Foto");
        }
        //--------------------------------------------------
        public ActionResult BLogComment()
        {
            var blogcom = c.BlogComments.ToList();
            return View(blogcom);
        }
        [HttpPost]
        public ActionResult BLogComment(string TextName, BlogComment blo)
        {
            var blogSiyahisi = c.BlogComments.Where(p => p.Blog.TextName.Contains(TextName)).ToList();
            return View(blogSiyahisi);
        }
        public ActionResult ExportPDFBLogComment()
        {
            return new ActionAsPdf("BLogComment")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        public ActionResult BlogCommentSil(int id)
        {
            var blogcomment = c.BlogComments.Find(id);
            c.BlogComments.Remove(blogcomment);
            c.SaveChanges();
            return RedirectToAction("BLogComment");
        }
        [HttpGet]
        public ActionResult YeniBlogComment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlogComment(BlogComment f)
        {
            c.BlogComments.Add(f);
            c.SaveChanges();
            return RedirectToAction("BLogComment");
        }
        public ActionResult BlogCommentGetir(int id)
        {
            var blogcomment = c.BlogComments.Find(id);
            return View("BlogCommentGetir", blogcomment);
        }

        public ActionResult BlogCommentYenile(BlogComment bc)
        {
            var adres = c.BlogComments.Find(bc.ID);
            adres.Name = bc.Name;
            adres.Mail = bc.Mail;
            adres.Text = bc.Text;
            adres.BlogID = bc.BlogID;
            adres.Telefon = bc.Telefon;
            adres.Saat = bc.Saat;
            adres.Tarix = bc.Tarix;
            c.SaveChanges();
            return RedirectToAction("BLogComment");
        }
        //-----------------------------------------------------------
        public ActionResult Admin()
        {
            var admin = c.Admins.ToList();
            return View(admin);
        }
        public ActionResult AdminSil(int id)
        {
            var admin = c.Admins.Find(id);
            c.Admins.Remove(admin);
            c.SaveChanges();
            return RedirectToAction("Admin");
        }
        public ActionResult ExportPDFAdmin()
        {
            return new ActionAsPdf("Admin")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        [HttpGet]
        public ActionResult YeniAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniAdmin(Admin a)
        {
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Admin");
        }
        public ActionResult AdminGetir(int id)
        {
            var admin = c.Admins.Find(id);
            return View("AdminGetir", admin);
        }

        public ActionResult AdminYenile(Admin bc)
        {
            var adres = c.Admins.Find(bc.ID);
            adres.User = bc.User;
            adres.Password = bc.Password;
            c.SaveChanges();
            return RedirectToAction("Admin");
        }
        //-----------------------------------------------------
        [HttpGet]
        public ActionResult LessonComment()
        {
            var lessoncomment = c.LessonComments.ToList();
            return View(lessoncomment);
        }
        [HttpPost]
        public ActionResult LessonComment(string TextName, LessonComment blo)
        {
            var blogSiyahisi = c.LessonComments.Where(p => p.LessonInformation.TextName.Contains(TextName)).ToList();
            return View(blogSiyahisi);
        }
        public ActionResult ExportPDFLessonComment()
        {
            return new ActionAsPdf("LessonComment")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        public ActionResult LessonCommentSil(int id)
        {
            var lessoncomment = c.LessonComments.Find(id);
            c.LessonComments.Remove(lessoncomment);
            c.SaveChanges();
            return RedirectToAction("LessonComment");
        }
        [HttpGet]
        public ActionResult YeniLessonComment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniLessonComment(LessonComment le)
        {
            c.LessonComments.Add(le);
            c.SaveChanges();
            return RedirectToAction("LessonComment");
        }
        public ActionResult LessonCommentGetir(int id)
        {
            var lessoncomment = c.LessonComments.Find(id);
            return View("LessonCommentGetir", lessoncomment);
        }

        public ActionResult LessonCommentYenile(LessonComment bc)
        {
            var adres = c.LessonComments.Find(bc.ID);
            adres.Name = bc.Name;
            adres.Mail = bc.Mail;
            adres.Text = bc.Text;
            adres.LessonID = bc.LessonID;
            adres.Telefon = bc.Telefon;
            adres.Saat = bc.Saat;
            adres.Tarix = bc.Tarix;
            
            c.SaveChanges();
            return RedirectToAction("LessonComment");
        }
        //----------------------------------------------------------
        [HttpGet]
        public ActionResult Contact()
        {
            var contact = c.Contacts.ToList();
            return View(contact);
        }
        [HttpPost]
        public ActionResult Contact(string TextName, Contact blo)
        {
            var blogSiyahisi = c.Contacts.Where(p => p.NameSurname.Contains(TextName)).ToList();
            return View(blogSiyahisi);
        }
        public ActionResult ExportPDFContact()
        {
            return new ActionAsPdf("Contact")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        public ActionResult ContactSil(int id)
        {
            var contact = c.Contacts.Find(id);
            c.Contacts.Remove(contact);
            c.SaveChanges();
            return RedirectToAction("Contact");
        }
        public ActionResult ContactGetir(int id)
        {
            var contact = c.Contacts.Find(id);
            return View("ContactGetir", contact);
        }

        public ActionResult ContactYenile(Contact bc)
        {
            var adres = c.Contacts.Find(bc.ID);
            adres.NameSurname = bc.NameSurname;
            adres.Email = bc.Email;
            adres.Tel = bc.Tel;
            adres.Message = bc.Message;
            adres.Date = bc.Date;
            adres.Time = bc.Time;
           

            c.SaveChanges();
            return RedirectToAction("Contact");
        }
        //-------------------------------------------------------------
        // Login prosesi
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var loginadmin = c.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
            if (loginadmin !=null)
            {
                FormsAuthentication.SetAuthCookie(loginadmin.User, false);
                Session["User"] = loginadmin.User.ToString();
                return RedirectToAction("Blog", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Admin");
        }
        //------------------------------------------------------------------
        [HttpGet]
        public ActionResult Service()
        {
            var blogSiyahisi = c.services.ToList();
            return View(blogSiyahisi);
        }
        [HttpPost]
        public ActionResult Service(string TextName, ServiceInformation blo)
        {
            var blogSiyahisi = c.services.Where(p => p.ServicesName.Contains(TextName)).ToList();
            return View(blogSiyahisi);
        }
        public ActionResult ExportPDFService()
        {
            return new ActionAsPdf("Service")
            {
                FileName = Server.MapPath("~/Content/ListProducts.pdf")
            };
        }
        public ActionResult ServiceSil(int id)
        {
            var ser = c.services.Find(id);
            c.services.Remove(ser);
            c.SaveChanges();
            return RedirectToAction("Service");
        }
        [HttpGet]
        public ActionResult YeniService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniService(ServiceInformation a)
        {
            c.services.Add(a);
            c.SaveChanges();
            return RedirectToAction("Service");
        }
        public ActionResult ServiceGetir(int id)
        {
            var lessoncomment = c.services.Find(id);
            return View("ServiceGetir", lessoncomment);
        }

        public ActionResult ServiceYenile(ServiceInformation bc)
        {
            var adres = c.services.Find(bc.ServicesID);
            adres.ServicesName = bc.ServicesName;
            adres.ServiceIcon = bc.ServiceIcon;
            adres.ServicesText = bc.ServicesText;
            c.SaveChanges();
            return RedirectToAction("Service");
        }
        //---------------------------------------------------------------
    }
}