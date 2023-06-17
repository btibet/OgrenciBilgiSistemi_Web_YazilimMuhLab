using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DersListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_DERSLERTableAdapter sınıfından bir örnek oluşturuluyor
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

            // DersListesi() metodu kullanılarak derslerin veritabanından alınması sağlanıyor
            Repeater1.DataSource = dt.DersListesi();

            // Derslerin tekrarlayıcı (Repeater) kontrolüne bağlanması ve verilerin görüntülenmesi sağlanıyor
            Repeater1.DataBind();
        }
    }
}
