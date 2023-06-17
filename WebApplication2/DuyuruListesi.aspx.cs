using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Veritabanından duyuru verilerini almak için TBL_DUYURULARTableAdapter sınıfı kullanılır.
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            // Repeater1 kontrolünün veri kaynağı olarak dt.DuyuruListesi() metodu kullanılır.
            // Bu metot, veritabanındaki tüm duyuru verilerini döndürür.
            Repeater1.DataSource = dt.DuyuruListesi();

            // Veriler Repeater kontrolüne bağlanır ve görüntülenir.
            Repeater1.DataBind();
        }
    }
}
