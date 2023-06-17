using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturuluyor
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A59ONIF\SQLEXPRESS;Initial Catalog=OBSWEB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde yapılacak işlemler
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Öğrenci girişi için butona tıklandığında yapılacak işlemler
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from TBL_OGRENCI where NUMARA=@p1 and OGRSIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                // Giriş başarılı ise kullanıcıya ait numara bilgisi Session'a ekleniyor ve ilgili sayfaya yönlendiriliyor
                Session.Add("NUMARA", TxtNumara.Text);
                Response.Redirect("OgrenciDefault.aspx");
            }
            else
            {
                // Giriş başarısız ise hatalı şifre mesajı gösteriliyor
                TxtSifre.Text = "Hatalı şifre";
            }
            baglanti.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Öğretmen girişi için butona tıklandığında yapılacak işlemler
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from TBL_OGRETMEN where OGRNUMARA=@p1 and OGRTSIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                // Giriş başarılı ise öğretmen numarası Session'a ekleniyor ve ilgili sayfaya yönlendiriliyor
                Session.Add("OGRNUMARA", TxtNumara.Text);
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                // Giriş başarısız ise hatalı şifre mesajı gösteriliyor
                TxtSifre.Text = "Hatalı şifre";
            }
            baglanti.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Yönetici girişi için butona tıklandığında yapılacak işlemler
            if (TxtNumara.Text == "admin" && TxtSifre.Text == "admin")
            {
                // Kullanıcı adı ve şifre doğru ise yönetici numarası Session'a ekleniyor ve ilgili sayfaya yönlendiriliyor
                Session.Add("OGRNUMARA", TxtNumara.Text);
                Response.Redirect("YoneticiDefault.aspx");
            }
            else
            {
                // Giriş başarısız ise hatalı şifre mesajı gösteriliyor
                TxtSifre.Text = "Hatalı şifre";
            }
        }
    }
}
