using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndirimKod.Models
{
    public class IndirimlerInitializer:DropCreateDatabaseIfModelChanges<IndirimlerContext>
    {
        protected override void Seed(IndirimlerContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){ KategoriAdi="Giyim"},
                new Kategori(){ KategoriAdi="Seyhat"},
                new Kategori(){ KategoriAdi="Eğlence"},
                new Kategori(){ KategoriAdi="Eğitim"},
            };

            foreach (var item in kategoriler) {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();


            List<Indirimler> indirim = new List<Indirimler>() {
            new Indirimler(){Baslik="Trendyol Yeni Yıl İndirimi", Aciklama="Trendyol Yeni Yıl İndirimi İçin Herkese Kuponlar Dağıtıyor. Sende Bu Kuponları Almak İçin Detaylara Tıkla",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=true,Icerik="Trendyol Yeni Yıl İndirimi İçin Herkese Kuponlar Dağıtıyor. Sende Bu Kuponları Almak Websitesi Veya Mobil Uygulamadan Erişebilirsin",Resim="Trendyol.jpg",KategoriId=1},
            new Indirimler(){Baslik="Ebilet Yeni Yıl İndirimi", Aciklama="Ebilet Yeni Yıl İndirimi İçin Herkese Kuponlar Dağıtıyor. Sende Bu Kuponları Almak İçin Detaylara Tıkla",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="Ebilet Yeni Yıl İndirimi İçin Herkese Kuponlar Dağıtıyor. Sende Bu Kuponları Almak Websitesi Veya Mobil Uygulamadan Erişebilirsin",Resim="Ebilet.jpg",KategoriId=2},
            new Indirimler(){Baslik="Trendyol İndirimi", Aciklama="Trendyol İndirimi İçin Herkese Kuponlar Dağıtıyor. Sende Bu Kuponları Almak İçin Detaylara Tıkla",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=false,Onay=false,Icerik="Trendyol İndirimi İçin Herkese Kuponlar Dağıtıyor. Sende Bu Kuponları Almak Websitesi Veya Mobil Uygulamadan Erişebilirsin",Resim="Trendyol.jpg",KategoriId=1}
            };

            foreach (var item in indirim)
            {
                context.Indirim.Add(item);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}