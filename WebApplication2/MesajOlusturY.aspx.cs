using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class MesajOluşturY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde "TxtGonderen" metin kutusuna "0002" değerini atayalım
            TxtGonderen.Text = "0002";
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            // TBL_MESAJLARTableAdapter sınıfından bir örnek oluşturalım
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // Mesajı göndermek için MesajGonder metodunu kullanalım
            dt.MesajGonder(TxtGonderen.Text, TxtAlici.Text, TxtBaslik.Text, Txticerik.Text);

            // Mesaj gönderildikten sonra "MesajlarYonetici.aspx" sayfasına yönlendirelim
            Response.Redirect("MesajlarYonetici.aspx");
        }
    }
}
