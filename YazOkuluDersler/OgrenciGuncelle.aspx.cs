using Business_Logic_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace YazOkuluDersler
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            TxtID.Text = x.ToString();
            TxtID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.OgrenciDetayBLL(x);
                TxtOgrAd.Text = OgrList[0].Name.ToString();
                TxtOgrSoyad.Text = OgrList[0].Surname.ToString();
                TxtOgrFoto.Text = OgrList[0].Photo.ToString();
                TxtOgrNo.Text = OgrList[0].Number.ToString();
                TxtOgrSifre.Text = OgrList[0].Password.ToString();
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Name = TxtOgrAd.Text;
            ent.Surname = TxtOgrSoyad.Text;
            ent.Photo = TxtOgrFoto.Text;
            ent.Number = TxtOgrNo.Text;
            ent.Password = TxtOgrSifre.Text;
            ent.Id = Convert.ToInt32(TxtID.Text);
            BLLOgrenci.OrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}