using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_Layer;
using Entity_Layer;
using Business_Logic_Layer;

namespace YazOkuluDersler
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Name = TxtOgrAd.Text;
            ent.Surname = TxtOgrSoyad.Text;
            ent.Number = TxtOgrNo.Text;
            ent.Password = TxtOgrSifre.Text;
            ent.Photo = TxtOgrFoto.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}