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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.DersListeleBLL();
                DrpDers.DataSource = BLLDers.DersListeleBLL();
                DrpDers.DataTextField = "Lesson_name";
                DrpDers.DataValueField = "Id";
                DrpDers.DataBind();
            }

        }

        protected void BtnDers_Click(object sender, EventArgs e)
        {
            //TxtOgrID.Text = DrpDers.SelectedValue.ToString();

            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basogrid = int.Parse(TxtOgrID.Text);
            ent.Basdersid = int.Parse(DrpDers.SelectedValue.ToString());
            BLLDers.TalepDersEkleBLL(ent);
         
        }
    }
}