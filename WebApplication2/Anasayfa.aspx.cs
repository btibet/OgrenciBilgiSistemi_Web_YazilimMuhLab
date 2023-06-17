using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_OGRENCITableAdapter sınıfından bir örnek oluşturuluyor.
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();

            // Repeater1 kontrolünün veri kaynağı olarak TBL_OGRENCITableAdapter sınıfının OgrenciListesi() metodu atanıyor.
            Repeater1.DataSource = dt.OgrenciListesi();

            // Verilerin Repeater1 kontrolüne bağlanması sağlanıyor.
            Repeater1.DataBind();
        }
    }
}