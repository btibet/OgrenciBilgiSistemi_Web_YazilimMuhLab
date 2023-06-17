using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde çalışacak olan olay işleyicisi

            // Session nesnesinden "NUMARA" anahtarının değerini alarak TxtNumara metin kutusuna yerleştiriyoruz
            TxtNumara.Text = Session["NUMARA"].ToString();

            // DataSet1TableAdapters.TBL_OGRENCITableAdapter sınıfını kullanarak bir örnek oluşturuyoruz
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();

            // TxtAdSoyad metin kutusuna "Ad Soyad: " metnini ve öğrencinin adını ve soyadını ekliyoruz
            TxtAdSoyad.Text = "Ad Soyad: " + dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRAD + " " + dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRSOYAD;

            // TxtMail metin kutusuna "Mail Adresi: " metnini ve öğrencinin mail adresini ekliyoruz
            TxtMail.Text = "Mail Adresi: " + dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRMAIL;

            // TxtSifre metin kutusuna "Şifre: " metnini ve öğrencinin şifresini ekliyoruz
            TxtSifre.Text = "Şifre: " + dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRSIFRE;

            // TxtTelefon metin kutusuna "Telefon: " metnini ve öğrencinin telefon numarasını ekliyoruz
            TxtTelefon.Text = "Telefon: " + dt.OgrenciPaneliGetir(TxtNumara.Text)[0].OGRTEL;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Button4 tıklanma olayı işleyicisi

            // Response.Redirect metoduyla OgrenciGuncelle2.aspx sayfasına yönlendirme yaparız ve NUMARA parametresi olarak TxtNumara metin kutusunun değerini kullanırız
            Response.Redirect("OgrenciGuncelle2.aspx?NUMARA=" + TxtNumara.Text);
        }
    }
}
