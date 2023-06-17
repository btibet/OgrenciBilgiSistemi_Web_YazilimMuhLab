using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_OGRENCITableAdapter sınıfını kullanarak veritabanına öğrenci ekleme işlemi gerçekleştiriliyor
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciEkle(TxtOgrNum.Text, TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text);

            // Öğrenci ekleme işleminden sonra Anasayfa.aspx sayfasına yönlendiriliyor
            Response.Redirect("Anasayfa.aspx");
        }
    }
}
