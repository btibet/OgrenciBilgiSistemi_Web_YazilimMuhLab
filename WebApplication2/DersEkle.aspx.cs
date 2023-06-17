using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DersEkle : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_DERSLERTableAdapter sınıfından bir örnek oluşturuluyor.
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

            // TBL_DERSLERTableAdapter sınıfının DersEkle() metodu kullanılarak yeni bir ders ekleniyor.
            dt.DersEkle(TxtDersAd.Text);

            // "DersListesiY.aspx" sayfasına yönlendirme yapılıyor.
            Response.Redirect("DersListesiY.aspx");
        }
    }
}