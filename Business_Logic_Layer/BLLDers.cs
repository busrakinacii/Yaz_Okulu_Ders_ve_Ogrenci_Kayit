using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListeleBLL()
        {
            return DALDers.DersListesi();
        }

        public static int TalepDersEkleBLL(EntityBasvuruForm p)
        {
            if(p.Basogrid != null && p.Basdersid != null)
            { 
                return DALDers.TalepEkle(p);

            }
            return -1;
        }
    }
}
