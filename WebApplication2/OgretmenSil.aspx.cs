using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgretmenSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OGRTID"].ToString());
            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
            dt.OgretmenSil(id);
            Response.Redirect("OgretmenListesi.aspx");
        }
    }
}