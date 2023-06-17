using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruListesiY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_DUYURULARTableAdapter nesnesi oluşturulur
            // Bu nesne, TBL_DUYURULAR tablosuna erişim sağlar
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            // Repeater1 kontrolünün veri kaynağı olarak TBL_DUYURULAR tablosundan gelen veriler atanır
            Repeater1.DataSource = dt.DuyuruListesi();

            // Repeater1 kontrolü verileri bağlar ve görüntüler
            Repeater1.DataBind();
        }
    }
}
