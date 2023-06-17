using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class GelenMesaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_MESAJLARTableAdapter sınıfından bir örnek oluşturulur
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // Repeater kontrolüne veri kaynağı olarak öğretmene gelen mesajları atanır
            Repeater1.DataSource = dt.OgretmenGelenMesaj(Session["OGRNUMARA"].ToString());

            // Veri bağlama işlemi gerçekleştirilir
            Repeater1.DataBind();
        }
    }
}
