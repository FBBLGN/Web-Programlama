﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndirimKod.Models
{
    public class KategoriModel
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public int IndirimSayisi { get; set; }
    }
}