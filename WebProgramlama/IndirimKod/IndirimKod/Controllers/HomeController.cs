using IndirimKod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndirimKod.Controllers
{
    public class HomeController : Controller
    {
        private IndirimlerContext context = new IndirimlerContext();
        // GET: Home
        public ActionResult Index()
        {
            var Indirim = context.Indirim
                .Where(i => i.Onay == true && i.Anasayfa == true)
                .Select(i => new IndirimlerModel() 
            {
                Id=i.Id,
                Baslik=i.Baslik.Length>100?i.Baslik.Substring(0,100)+"...":i.Baslik,
                Aciklama=i.Aciklama,
                EklenmeTarihi=i.EklenmeTarihi,
                Anasayfa=i.Anasayfa,
                Onay=i.Onay,
                Resim=i.Resim
            }
            );
            return View(Indirim.ToList());
        }
    }
}