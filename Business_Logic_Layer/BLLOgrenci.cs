using Entity_Layer;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Name != null && p.Surname != null && p.Number != null && p.Password != null && p.Photo != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p>=0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;

        }

        public static List<EntityOgrenci> OgrenciDetayBLL(int id)
        {
            return DALOgrenci.OgrenciDetay(id);
        }

        public static bool OrenciGuncelleBLL(EntityOgrenci a)
        {
            if (a.Name != null && a.Name!="" && a.Surname != null && a.Surname != ""  && a.Number != null && a.Number != "" && a.Password != null && a.Password != "" && a.Photo != null && a.Photo != "" && a.Id>0)
            {
                return DALOgrenci.OgrenciGuncelle(a);
            }
            return false;
        }
    }
}
