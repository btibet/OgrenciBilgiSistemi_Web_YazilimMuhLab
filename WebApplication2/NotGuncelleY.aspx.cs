using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotGuncelleY : System.Web.UI.Page
    {
        int nid; // Öğrenci ID'sini tutmak için bir değişken tanımlanır

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // Sayfa postback olmadığında gerçekleştirilecek işlemler

                nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString()); // URL'den NOTID parametresini alarak öğrenci ID'sini belirler

                DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter(); // Dataset içerisindeki ogrnotlarTableAdapter nesnesi oluşturulur

                TxtOgrAdSoyad.Text = dt.NotGetir2(nid)[0].OGRENCIADSOYAD; // TxtOgrAdSoyad TextBox'ına öğrenci adı ve soyadı yazılır
                TxtDersAd.Text = dt.NotGetir2(nid)[0].DERSAD; // TxtDersAd TextBox'ına ders adı yazılır
                TxtOgrDurum.Text = dt.NotGetir2(nid)[0].DURUM.ToString(); // TxtOgrDurum TextBox'ına öğrenci durumu yazılır
                TxtOgrSınav1.Text = dt.NotGetir2(nid)[0].SINAV1.ToString(); // TxtOgrSınav1 TextBox'ına 1. sınav notu yazılır
                TxtOgrSınav2.Text = dt.NotGetir2(nid)[0].SINAV2.ToString(); // TxtOgrSınav2 TextBox'ına 2. sınav notu yazılır
                TxtOgrSınav3.Text = dt.NotGetir2(nid)[0].SINAV3.ToString(); // TxtOgrSınav3 TextBox'ına 3. sınav notu yazılır
                TxtOgrOrt.Text = dt.NotGetir2(nid)[0].ORTALAMA.ToString(); // TxtOgrOrt TextBox'ına not ortalaması yazılır
                TxtOgrid.Text = dt.NotGetir2(nid)[0].OGRENCIID.ToString(); // TxtOgrid TextBox'ına öğrenci ID'si yazılır
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Button1 tıklandığında gerçekleştirilecek işlemler

            double sinav1, sinav2, sinav3;
            double ort;

            sinav1 = Convert.ToInt32(TxtOgrSınav1.Text); // TxtOgrSınav1 TextBox'ından 1. sınav notu alınır
            sinav2 = Convert.ToInt32(TxtOgrSınav2.Text); // TxtOgrSınav2 TextBox'ından 2. sınav notu alınır
            sinav3 = Convert.ToInt32(TxtOgrSınav3.Text); // TxtOgrSınav3 TextBox'ından 3. sınav notu alınır

            ort = (sinav1 + sinav2 + sinav3) / 3; // Not ortalaması hesaplanır
            TxtOgrOrt.Text = ort.ToString("0.00"); // TxtOgrOrt TextBox'ına not ortalaması yazılır

            if (ort <= 50)
            {
                // Not ortalaması 50'den küçük veya eşitse

                TxtOgrDurum.Text = "False"; // TxtOgrDurum TextBox'ına "False" değeri yazılır (öğrenci başarısız)
            }
            else if (ort >= 50)
            {
                // Not ortalaması 50'den büyük veya eşitse

                TxtOgrDurum.Text = "True"; // TxtOgrDurum TextBox'ına "True" değeri yazılır (öğrenci başarılı)
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Button2 tıklandığında gerçekleştirilecek işlemler

            nid = Convert.ToInt32(Request.QueryString["NOTID"].ToString()); // URL'den NOTID parametresini alarak öğrenci ID'sini belirler

            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter(); // Dataset içerisindeki ogrnotlarTableAdapter nesnesi oluşturulur

            dt.NotGuncelle(byte.Parse(TxtOgrSınav1.Text), byte.Parse(TxtOgrSınav2.Text), byte.Parse(TxtOgrSınav3.Text), decimal.Parse(TxtOgrOrt.Text), bool.Parse(TxtOgrDurum.Text), nid); // Öğrenci notlarını güncellemek için NotGuncelle metodunu çağırır

            Response.Redirect("NotListesiY.aspx"); // NotListesiY sayfasına yönlendirme yapılır
        }
    }
}
