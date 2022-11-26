﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndApp.Model
{
    internal class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public int YazarID { get; set; }
        public int KategoriID { get; set; }
        public decimal Fiyat { get; set; }

        public string KapakResmi { get; set; }
        public DateTime EklendigiTarih { get; set; }

        public override string ToString()
        {
            return KitapID + " "+ KitapAdi + " " + KategoriID + " " + Fiyat;
        }
    }
}
