﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int Satisid { get; set; }
        //ürün
        //cari
        //personel
        public DateTime Tarih { get; set; }
        public int Adet{ get; set; }
        public decimal Fiyat{ get; set; }
        public decimal ToplamTutar{ get; set; }
        public int Urunid { get; set; }
        public int Cariid { get; set; }
        public int Personelid { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Cari Cari{ get; set; }
        public virtual Personel Personel{ get; set; }
    }
}