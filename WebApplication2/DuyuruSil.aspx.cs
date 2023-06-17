using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // URL üzerinden gelen "DUYURUID" parametresi alınır ve integer türüne dönüştürülür
            int id = Convert.ToInt32(Request.QueryString["DUYURUID"].ToString());

            // DataSet1TableAdapters.TBL_DUYURULARTableAdapter nesnesi oluşturulur
            // Bu nesne, TBL_DUYURULAR tablosuna erişim sağlar
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            // Belirtilen "DUYURUID" değerine sahip duyuruyu veritabanından siler
            dt.DuyuruSil(id);

            // Kullanıcıyı "DuyuruListesi.aspx" sayfasına yönlendirir
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}
