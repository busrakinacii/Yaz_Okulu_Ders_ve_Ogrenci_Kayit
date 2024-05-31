using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;

namespace Data_Access_Layer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Connect.conn);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Name);
            komut1.Parameters.AddWithValue("@p2", parametre.Surname);
            komut1.Parameters.AddWithValue("@p3", parametre.Number);
            komut1.Parameters.AddWithValue("@p4", parametre.Photo);
            komut1.Parameters.AddWithValue("@p5", parametre.Password);
            return komut1.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From TBLOGRENCI", Connect.conn);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Name = dr["OGRAD"].ToString();
                ent.Surname = dr["OGRSOYAD"].ToString();
                ent.Number = dr["OGRNUMARA"].ToString();
                ent.Photo = dr["OGRFOTO"].ToString();
                ent.Password = dr["OGRSIFRE"].ToString();
                ent.Balance = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;


        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBLOGRENCI where OGRID=@p1", Connect.conn);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> lst = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * from TBLOGRENCI where OGRID=@p1", Connect.conn);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Name = dr["OGRAD"].ToString();
                ent.Surname = dr["OGRSOYAD"].ToString();
                ent.Number = dr["OGRNUMARA"].ToString();
                ent.Photo = dr["OGRFOTO"].ToString();
                ent.Password = dr["OGRSIFRE"].ToString();
                ent.Balance = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                lst.Add(ent);
            }
            dr.Close();
            return lst;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCI set OGRAD=@p1,OGRSOYAD=@p2,OGRNUMARA=@p3,OGRFOTO=@p4,OGRSIFRE=@p5 where OGRID=@p6", Connect.conn);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.Name);
            komut5.Parameters.AddWithValue("@p2", deger.Surname);
            komut5.Parameters.AddWithValue("@p3", deger.Number);
            komut5.Parameters.AddWithValue("@p4", deger.Photo);
            komut5.Parameters.AddWithValue("@p5", deger.Password);
            komut5.Parameters.AddWithValue("@p6", deger.Id);

            return komut5.ExecuteNonQuery() > 0;

        }

    }
}
