using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndApp.Model;

namespace WndApp.DAL
{
    internal class YazarYonetici : ICRUD<Yazar>
    {
        public Yazar Ara(int id)
        {
            KitapDB._conn.Open();
            throw new NotImplementedException();
            KitapDB._conn.Close();
        }

        public void Ekle(Yazar entity)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Yazar entity)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> Listele()
        {
            KitapDB._conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Yazarlar", KitapDB._conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Yazar> list = new List<Yazar>();
            while (reader.Read())
            {
                Yazar yazar = new Yazar();
                yazar.YazarID = reader.GetInt32(0);
                yazar.YazarAdi = reader.GetString(1);

                list.Add(yazar);
            }

            KitapDB._conn.Close();
            return list;
        }

        public void Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
