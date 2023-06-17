using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class MesajlarYonetici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Veritabanı tablo adaptörü oluşturuluyor
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // Repeater veri kaynağı olarak mesajları alıyor
            Repeater1.DataSource = dt.MesajlariGetir();

            // Veriler tekrarlayıcıya bağlanıyor
            Repeater1.DataBind();
        }
    }
}
