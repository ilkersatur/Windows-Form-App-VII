using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WndApp.Model;
namespace WndApp.DAL
{
    internal class KategoriYonetici : ICRUD<Kategori>
    {
        public Kategori Ara(int id)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Kategori entity)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Kategori entity)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> Listele()
        {
            KitapDB._conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Kategoriler", KitapDB._conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Kategori> list = new List<Kategori>();
            while (reader.Read())
            { 
                Kategori item = new Kategori();
                item.KategoriID = reader.GetInt32(0);
                item.KategoriAdi = reader.GetString(1);

                list.Add(item);
            }

            KitapDB._conn.Close();
            return list;
        }

        public void Sil(int id)
        {
            KitapDB._conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Kategoriler WHERE KategoriID=@katID", KitapDB._conn);

            cmd.Parameters.AddWithValue("@katID", id);
            cmd.ExecuteNonQuery();
            KitapDB._conn.Close();
            
        }
    }
}
