using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciMesajOlustur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde gönderenin adını alarak metin kutusuna atama yapar
            TxtGonderen.Text = Session["NUMARA"].ToString();
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            // TBL_MESAJLARTableAdapter sınıfından bir örnek oluşturulur
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // MesajGonder metodu kullanılarak mesaj gönderme işlemi gerçekleştirilir
            dt.MesajGonder(TxtGonderen.Text, TxtAlici.Text, TxtBaslik.Text, TxtMesajicerik.Value);

            // Mesaj gönderildikten sonra OgrenciGiden.aspx sayfasına yönlendirme yapılır
            Response.Redirect("OgrenciGiden.aspx");
        }
    }
}
