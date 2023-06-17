using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DersListesiY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSet1 veri tabanı tablosu ile etkileşim sağlayan bir adapter oluşturuluyor
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

            // Repeater kontrolüne veri kaynağı olarak ders listesini atanıyor
            Repeater1.DataSource = dt.DersListesi();

            // Veri bağlama işlemi gerçekleştiriliyor
            Repeater1.DataBind();
        }
    }
}
