using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndirimKod.Models
{
    public class IndirimlerContext:DbContext
    {
        public IndirimlerContext():base("IndirimDB")
        {
            Database.SetInitializer(new IndirimlerInitializer());
        }
        public DbSet<Indirimler> Indirim { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}