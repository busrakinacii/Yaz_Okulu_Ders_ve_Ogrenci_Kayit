using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


namespace Data_Access_Layer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> deger = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", Connect.conn);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Lesson_name = dr["DERSAD"].ToString();
                ent.Max = Convert.ToInt32(dr["DERSMAKSKONT"].ToString());
                ent.Min = Convert.ToInt32(dr["DERSMINKONT"].ToString());
                deger.Add(ent);
            }
            dr.Close();
            return deger;


        }

        public static int TalepEkle(EntityBasvuruForm p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBASVURUFORM (OGRENCIID,DERSID) values (@p1,@p2)", Connect.conn);
            if(komut2.Connection.State!=ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Basogrid);
            komut2.Parameters.AddWithValue("@p2", p.Basdersid);
            return komut2.ExecuteNonQuery();
        }
    }
}
