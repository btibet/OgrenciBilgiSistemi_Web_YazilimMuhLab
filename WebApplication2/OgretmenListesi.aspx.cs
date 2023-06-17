using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgretmenListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TBL_OGRETMENTableAdapter sınıfından bir instance oluşturuluyor
            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();

            // Repeater kontrolünün veri kaynağına TBL_OGRETMENTableAdapter üzerinden öğretmen listesini atıyoruz
            Repeater1.DataSource = dt.OgretmenListesi();

            // Veri bağlama işlemini gerçekleştiriyoruz
            Repeater1.DataBind();
        }
    }
}
