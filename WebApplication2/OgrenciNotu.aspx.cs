using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciNotu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde çalışan olay işleyicisi
            // DataSet1 içerisindeki ogrnotlarTableAdapter sınıfından bir örnek oluşturulur
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();

            // Repeater1 kontrolünün veri kaynağı olarak öğrenci notlarını alır
            // Session'da saklanan NUMARA değeri kullanılarak ilgili öğrencinin notları getirilir
            Repeater1.DataSource = dt.OgrenciNotu(Session["NUMARA"].ToString());

            // Veriler Repeater1 kontrolüne bağlanır
            Repeater1.DataBind();
        }
    }
}
