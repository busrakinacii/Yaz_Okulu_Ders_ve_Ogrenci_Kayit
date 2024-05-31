using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity_Layer;
using Data_Access_Layer;
using Business_Logic_Layer;

namespace YazOkuluDersler
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BLLListele();
            Repeater1.DataSource = OgrList; 
            Repeater1.DataBind();
        }
    }
}