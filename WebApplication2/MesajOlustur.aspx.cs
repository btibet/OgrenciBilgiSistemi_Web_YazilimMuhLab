using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class MesajOluştur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde çalışan metot
            // Gönderen metin kutusuna varsayılan bir değer atanıyor
            TxtGonderen.Text = "0002";
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            // "GÖNDER" butonuna tıklandığında çalışan metot
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // Mesaj gönderme işlemi yapılıyor
            dt.MesajGonder(TxtGonderen.Text, TxtAlici.Text, TxtBaslik.Text, Txticerik.Text);

            // GidenMesajlar.aspx sayfasına yönlendirme yapılıyor
            Response.Redirect("GidenMesajlar.aspx");
        }
    }
}
