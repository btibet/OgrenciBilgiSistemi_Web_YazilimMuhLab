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
            // URL'den "OGRTID" parametresini alarak integer'a dönüştürüyoruz
            int id = Convert.ToInt32(Request.QueryString["OGRTID"].ToString());

            // TBL_OGRETMENTableAdapter sınıfından bir instance oluşturuluyor
            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();

            // Öğretmeni silmek için OgretmenSil yöntemini kullanıyoruz
            dt.OgretmenSil(id);

            // Silme işlemi tamamlandıktan sonra OgretmenListesi.aspx sayfasına yönlendirme yapıyoruz
            Response.Redirect("OgretmenListesi.aspx");
        }
    }
}
