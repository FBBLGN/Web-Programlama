using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IndirimKod.Models;

namespace IndirimKod.Controllers
{
    public class IndirimlerController : Controller
    {
        private IndirimlerContext db = new IndirimlerContext();

        public ActionResult List(int? id, string AnahtarKelime) {
            var Indirim = db.Indirim
                .Where(i => i.Onay == true )
                .Select(i => new IndirimlerModel()
            {
                Id = i.Id,
                Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                Aciklama = i.Aciklama,
                EklenmeTarihi = i.EklenmeTarihi,
                Anasayfa = i.Anasayfa,
                Onay = i.Onay,
                Resim = i.Resim,
                KategoriId=i.KategoriId
            }
           ).AsQueryable();

            if (string.IsNullOrEmpty("AnahtarKelime") == false) {
                Indirim = Indirim.Where(i => i.Baslik.Contains(AnahtarKelime) || i.Aciklama.Contains(AnahtarKelime));
            }

            if (id != null) {
                Indirim = Indirim.Where(i => i.KategoriId == id);
            }
            return View(Indirim.ToList());
        }
        // GET: Indirimler
        public ActionResult Index()
        {
            var indirim = db.Indirim.Include(i => i.Kategori).OrderByDescending(i=>i.EklenmeTarihi);
            return View(indirim.ToList());
        }

        // GET: Indirimler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indirimler indirimler = db.Indirim.Find(id);
            if (indirimler == null)
            {
                return HttpNotFound();
            }
            return View(indirimler);
        }

        // GET: Indirimler/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "KategoriAdi");
            return View();
        }

        // POST: Indirimler/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Baslik,Resim,Aciklama,Icerik,KategoriId")] Indirimler indirimler)
        {
            if (ModelState.IsValid)
            {
                indirimler.EklenmeTarihi = DateTime.Now;
                indirimler.Onay = false;
                indirimler.Anasayfa = false;

                db.Indirim.Add(indirimler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "KategoriAdi", indirimler.KategoriId);
            return View(indirimler);
        }

        // GET: Indirimler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indirimler indirimler = db.Indirim.Find(id);
            if (indirimler == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "KategoriAdi", indirimler.KategoriId);
            return View(indirimler);
        }

        // POST: Indirimler/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Baslik,Resim,Aciklama,Icerik,Onay,Anasayfa,KategoriId")] Indirimler indirimler)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Indirim.Find(indirimler.Id);
                if (entity != null) {
                    entity.Baslik = indirimler.Baslik;
                    entity.Aciklama = indirimler.Aciklama;
                    entity.Resim = indirimler.Resim;
                    entity.Icerik = indirimler.Icerik;
                    entity.Onay = indirimler.Onay;
                    entity.Anasayfa = indirimler.Anasayfa;
                    entity.KategoriId = indirimler.KategoriId;

                    db.SaveChanges();

                    TempData["Indirimler"] = entity;
                    return RedirectToAction("Index");
                }
               
                
            }
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "Id", "KategoriAdi", indirimler.KategoriId);
            return View(indirimler);
        }

        // GET: Indirimler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indirimler indirimler = db.Indirim.Find(id);
            if (indirimler == null)
            {
                return HttpNotFound();
            }
            return View(indirimler);
        }

        // POST: Indirimler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Indirimler indirimler = db.Indirim.Find(id);
            db.Indirim.Remove(indirimler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
