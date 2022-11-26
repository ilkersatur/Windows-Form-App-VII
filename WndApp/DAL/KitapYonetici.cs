using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndApp.Model;

namespace WndApp.DAL
{
    internal class KitapYonetici : ICRUD<Kitap>
    {
        public Kitap Ara(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Kitap entity)
        {
            KitapDB._conn.Open();

            //SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar VALUES(@ad,@yazar,@kategori,@fiyat,@resim,getdate()", KitapDB._conn);
            SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar VALUES(@ad,@yazar,@kategori,@fiyat,@resim,@tarih)", KitapDB._conn);

            cmd.Parameters.AddWithValue("@ad", entity.KitapAdi);
            cmd.Parameters.AddWithValue("@yazar", entity.YazarID);
            cmd.Parameters.AddWithValue("@kategori", entity.KategoriID);
            cmd.Parameters.AddWithValue("@fiyat", entity.Fiyat);
            cmd.Parameters.AddWithValue("@resim", entity.KapakResmi);
            cmd.Parameters.AddWithValue("@tarih", entity.EklendigiTarih);
           

            cmd.ExecuteNonQuery();

            KitapDB._conn.Close();
            
        }

        public void Guncelle(Kitap entity)
        {
            throw new NotImplementedException();
        }

        public List<Kitap> Listele()
        {
            throw new NotImplementedException();
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
