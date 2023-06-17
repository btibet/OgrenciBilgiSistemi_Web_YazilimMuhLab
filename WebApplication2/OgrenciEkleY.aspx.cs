using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciEkleY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde yapılacak işlemler (herhangi bir kod olmadığı için boş bırakıldı)
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // "Kaydet" butonuna tıklandığında yapılacak işlemler
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciEkle(TxtOgrNum.Text, TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text);
            // Yukarıdaki kod, TBL_OGRENCI tablosuna yeni bir öğrenci kaydı eklemek için TBL_OGRENCITableAdapter'ı kullanır.
            // Metin kutularındaki değerler kullanılarak öğrenci bilgileri alınır ve kaydedilir.

            Response.Redirect("YoneticiDefault.aspx");
            // Kaydetme işleminden sonra YoneticiDefault.aspx sayfasına yönlendirme yapılır.
        }
    }
}
